using System;
using System.Collections.Generic;
using System.Threading;
using Es0203_Console.Classes;

namespace Es0203_Console
{
    class Program
    {
        static int nocli = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Quante sedie ci sono nel negozio?");
            int n;
            n=int.Parse(Console.ReadLine());


            barBuffer neg = new barBuffer(n);  
            Barbiere barb = new Barbiere(neg);

            Thread tbarb = new Thread(barb.taglia_capelli);
            tbarb.Name = "Barbiere";
            tbarb.Start();

            List<Thread> tcust = new List<Thread>(); 

            Random r = new Random();
            for (int i = 0; i < nocli; i++)
            {
                Cliente cli = new Cliente(neg);
                tcust.Add(new Thread(cli.entrata_cliente));
                tcust[i].Name = "Cliente" + cli.id;
                tcust[i].Start();
                Thread.Sleep(r.Next(500));
            }

            for(int i = 0; i < tcust.Count; i++)
            {
                tcust[i].Join();
            }

            neg.finito();

            tbarb.Join();




        }
    }
}
