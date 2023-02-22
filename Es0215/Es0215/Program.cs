using System;
using System.Collections.Generic;
using System.Threading;

namespace Es0215
{
    class Program
    {
        static Random rn;
        static void Main(string[] args)
        {
            rn = new Random();

            Bar b = new Bar(10);
            Barista barista = new Barista(b);
            List<Thread> tcustomers = new List<Thread>();
            Thread tbarista = new Thread(barista.Servi);
            tbarista.Start();

            for(int i = 0; i < 12; i++)
            {
                Tipo tip = new Tipo();
                if (rn.Next(0, 2) == 0)
                {
                    tip = Tipo.locale;
                }
                else
                {
                    tip = Tipo.ospite;
                }

                Tifoso t = new Tifoso(b, tip, i);
                tcustomers.Add(new Thread(t.Pausa));
                tcustomers[i].Start();
                Thread.Sleep(rn.Next(0, 2300));
            }
            for(int i = 0; i < tcustomers.Count; i++)
            {
                tcustomers[i].Join();
            }
            b.end();

            Console.WriteLine("Il locale è chiuso, tutti i clienti sono stati serviti!");
        }
    }
}
