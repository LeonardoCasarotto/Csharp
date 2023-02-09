using Es0208.Classes;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Es0208
{
    class Program
    {
        static int nocli;
        static Random rnd;
        static void Main(string[] args)
        {
            Pizzeria pi = new Pizzeria();
            Pizzaiolo chef = new Pizzaiolo(pi);
            
            List<Thread> tcust = new List<Thread>();
            Thread pizzaiolo = new Thread(chef.Lavora);
            pizzaiolo.Start();


            rnd = new Random();
            for(int i = 0; i < 5; i++)
            {
                TypeCli t = new TypeCli();
                if(rnd.Next(0, 2)== 0){
                    t = TypeCli.inPresenza;
                }
                else
                {
                    t = TypeCli.daRemoto;
                }
                Cliente cl = new Cliente(pi, t);

                tcust.Add(new Thread(cl.run));
                tcust[i].Start();
                Thread.Sleep(rnd.Next(0,2500));

            }
            for (int i = 0; i < tcust.Count; i++)
            {
                tcust[i].Join();
            }
            pi.fine();
            pizzaiolo.Join();

        }
    }
}
