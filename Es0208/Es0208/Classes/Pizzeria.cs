using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0208.Classes
{
    class Pizzeria
    {
        List<Cliente> clienti = new List<Cliente>();
        static object _ordine = new object();
        static object _alLavoro = new object();
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
                if (clienti.Count == 0) Monitor.Pulse(_alLavoro);
                if (c.tipo == TypeCli.daRemoto)
                {
                    clienti.Insert(0, c);
                }

                else if (c.tipo == TypeCli.inPresenza)
                {
                    clienti.Add(c);
                }
                Monitor.Pulse(_alLavoro);

            }

            lock (_ordine)
            {
                Console.WriteLine("Il cliente è in attesa di essere servito");
                Monitor.Wait(_ordine);

            }
        
        }
        
        public void Sforna()
        {
            while (!fin)
            {
                Console.WriteLine("PIZZAIOLO AL LAVORO");
                Cliente cliente = null;

                lock (_alLavoro)
                {
                    if (clienti.Count == 0)
                    {
                        Monitor.Wait(_alLavoro);

                    }



                    cliente = clienti[0];
                    clienti.RemoveAt(0);
                }

                lock (_ordine)
                {
                    if (cliente != null)
                    {
                        Console.WriteLine("Il cliente è servito");
                        Thread.Sleep(2000);
                        switch (cliente.tipo)
                        {
                            case TypeCli.inPresenza:
                                Passa();
                                break;
                            case TypeCli.daRemoto:
                                Spedisci();
                                break;
                        }

                        Monitor.Pulse(_ordine);
                    }

                }

            }

            

        }



        
        public void Spedisci()
        {
            Console.WriteLine("La pizza è stata spedita");
        }

        public void Passa()
        {
            Console.WriteLine("La pizza è stata affidata al cliente");
        }
    }
}
