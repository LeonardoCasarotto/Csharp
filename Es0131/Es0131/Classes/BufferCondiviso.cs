using System;
using System.Threading;



namespace Es0131.Classes
{
    public class BufferCondiviso
    {
        private Auto macchina;
        private bool PostoOccupato=false;

        static readonly object _lock = new object();
        public Auto Macchina
        {
            get //lettura
            {
                Auto copia;
                lock(_lock)
                {
                    if(PostoOccupato == false)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + "cerca se il parcheggio è vuoto");

                        Monitor.Wait(_lock);

                    }
                    PostoOccupato = false;
                    copia = macchina;
                    Monitor.Pulse(_lock);
                }
                return copia;
            }

            set
            {
                lock (_lock)
                {
                    if(PostoOccupato == true)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + "prova a parcheggiare");
                        Console.WriteLine("Posto già occupato");
                        Monitor.Wait(_lock);
                    }

                    macchina = value;
                    PostoOccupato = true;
                    //todo stampare al momento del parcheggio
                    Monitor.Pulse(_lock);
                }
            }
        }
    }
}
