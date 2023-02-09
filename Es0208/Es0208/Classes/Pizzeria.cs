using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0208.Classes
{
    class Pizzeria
    {
        List<Cliente> clienti = new List<Cliente>();
        Queue<Cliente> daSpedire = new Queue<Cliente>();
        Random rnd = new Random();
        static object _ordine = new object();
        static object _alLavoro = new object();
        static object _inConsegna = new object();
        static bool fin = false;

        
        
        
        public void fine()
        {
            fin = true;
            lock (_alLavoro)
            {

                Monitor.Pulse(_alLavoro);
            }
        }
        public void entrata_pizzeria(Cliente c) {

            lock (_alLavoro)
            {
                
                if (c.tipo == TypeCli.daRemoto)
                {
                    clienti.Insert(0, c);
                    Console.WriteLine("Il cliente "+c.id+" ha telefonato e ha ordinato una pizza");
                }

                else if (c.tipo == TypeCli.inPresenza)
                {
                    clienti.Add(c);
                    Console.WriteLine("Il cliente " + c.id + " è in negozio e ha ordinato una pizza");
                }
                Monitor.Pulse(_alLavoro);

            }

            lock (_ordine)
            {
                Console.WriteLine("Il cliente "+c.id+ " è in attesa di essere servito");
                Monitor.Wait(_ordine);

            }
        
        }
        
        public void Sforna()
        {
            while (!fin)
            {
                
                Cliente cliente = null;

                lock (_alLavoro)
                {
                    if (clienti.Count == 0)
                    {
                        Monitor.Wait(_alLavoro);

                    }
                    
                   


                    if (clienti.Count > 0)
                    {
                        cliente = clienti[0];
                        clienti.RemoveAt(0);
                    }
                }

                lock (_ordine)
                {
                    if (cliente != null)
                    {
                        
                        Thread.Sleep(2000);
                        
                        switch (cliente.tipo)
                        {
                            case TypeCli.inPresenza:
                                Passa(cliente.id);
                                break;
                            case TypeCli.daRemoto:
                                daSpedire.Enqueue(cliente);
                                
                                break;
                        }

                        Monitor.Pulse(_ordine);
                      
                    }
                    lock (_inConsegna)
                    {
                        Monitor.Pulse(_inConsegna);
                    }

                }

            }

            

        }



        
        

        public void Passa(int c)
        {
            Console.WriteLine("La pizza è stata affidata al cliente id "+c);
        }

        //FIXME after finishing, the program is not closing
        public void Consegna()
        {
            while (!fin)
            {
                lock (_inConsegna)
                {
                    if (daSpedire.Count == 0)
                    {
                        Monitor.Wait(_inConsegna);
                        


                    }
                    
                    daSpedire.TryDequeue(out Cliente temp);

                    if (temp != null)
                    {
                        Thread.Sleep(rnd.Next(0, 2500));
                        Console.WriteLine("La pizza è stata recapitata al cliente identificativo " + temp.id);
                    }
                }
            }
        }
    }
}
