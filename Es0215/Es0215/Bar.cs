using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0215
{
    class Bar
    {
        int nmax;
        ConcurrentQueue<Tifoso> blueTeam;//squadra locale
        ConcurrentQueue<Tifoso> redTeam;//squadra ospite

        object cli = new object();
        object ordine = new object();
        object alLavoro = new object();
        bool work = true;




        public Bar(int n)
        {
            this.nmax = n;
            blueTeam = new ConcurrentQueue<Tifoso>(); 
            redTeam =  new ConcurrentQueue<Tifoso>();
        }
        public void end()
        {
            work = false;
            lock (alLavoro)
            {
                Monitor.Pulse(alLavoro);
            }
            

        }

        public void EntrataCliente(Tifoso t)
        {
            
                lock (alLavoro) 
                {

                if (t.getSquadra() == Tipo.locale && blueTeam.Count == nmax || t.getSquadra() == Tipo.ospite && redTeam.Count == nmax)
                {
                    
                    Console.WriteLine("Il cliente identificativo "+t.getId()+" non può entrare al bar, locale pieno!");
                    return;
                }
                    if (t.getSquadra() == Tipo.locale)
                    {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    blueTeam.Enqueue(t);
                    }

                    else if (t.getSquadra() == Tipo.ospite)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    redTeam.Enqueue(t);
                    }
                    Monitor.Pulse(alLavoro);
                }
                lock (ordine)
                {
                    Console.WriteLine("Il Tifoso " + t.getId()+ " è in attesa di essere servito");
                    Monitor.Wait(ordine);
                }



            

        }

        public void BarInFunzione()
        {
            while (work)
            {
                lock (alLavoro)
                {
                    Random rnd = new Random();
                    if (blueTeam.Count > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Il turno al bar spetta alla squadra locale");
                        serviBlu(rnd);
                    }
                    else if (redTeam.Count > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Il turno al bar spetta alla squadra ospite");
                        serviRosso(rnd);
                    }
                    else
                    {
                        Monitor.Wait(alLavoro);

                    }
                }



            }










        }

        void serviBlu(Random rn)
        {
            lock (ordine)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                while (!blueTeam.IsEmpty)
                {   
                    Tifoso temp = null;

                    blueTeam.TryDequeue(out temp);
                    if (temp != null)
                    {
                        Thread.Sleep(rn.Next(0, 2300));
                        Console.WriteLine("Il cliente della squadra locale identificativo " + temp.getId() + " è stato servito");
                        Monitor.Pulse(ordine);
                    }
                }

            }
        }

        void serviRosso(Random rn)
        {
            lock (ordine)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                while (!redTeam.IsEmpty)
                {
                    Tifoso temp = null;

                    redTeam.TryDequeue(out temp);
                    if (temp != null)
                    {
                        Thread.Sleep(rn.Next(0, 2300));
                        Console.WriteLine("Il cliente della squadra ospite identificativo " + temp.getId() + " è stato servito");
                        Monitor.Pulse(ordine);
                    }
                }
            }
        }
    }
}
