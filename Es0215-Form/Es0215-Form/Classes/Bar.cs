using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Es0215_Form.Classes
{
    class Bar
    {
        
            int nmax;
            ConcurrentQueue<Tifoso> blueTeam;//squadra locale
            ConcurrentQueue<Tifoso> redTeam;//squadra ospite


            object ordine = new object();
            object alLavoro = new object();
            bool work = true;
        Form1 formain;




            public Bar(int n, Form1 f)
            {
                this.nmax = n;
                blueTeam = new ConcurrentQueue<Tifoso>();
                redTeam = new ConcurrentQueue<Tifoso>();
            this.formain = f;
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

                        
                        return;
                    }
                    if (t.getSquadra() == Tipo.locale)
                    {
                        
                        blueTeam.Enqueue(t);
                    }

                    else if (t.getSquadra() == Tipo.ospite)
                    {
                        
                        redTeam.Enqueue(t);
                    }
                    Monitor.Pulse(alLavoro);
                }
                lock (ordine)
                {
                    
                    formain.Counter(t.getSquadra(), 1);
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
                        if (rnd.Next(0, 2) == 0)
                        {

                            formain.Pulizia();

                            Thread.Sleep(5000);

                        }


                        if (blueTeam.Count > 0)
                        {
                        formain.CgTeam(Tipo.locale);
                        serviBlu(rnd);
                        }
                        else if (redTeam.Count > 0)
                        {
                            

                         formain.CgTeam(Tipo.ospite);
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
                            formain.Counter(Tipo.locale, -1);
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
                            formain.Counter(Tipo.ospite, -1);
                        Monitor.Pulse(ordine);
                        }
                    }
                }
            }
        }
    }

