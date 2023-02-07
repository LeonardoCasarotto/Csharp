using System;
using System.Collections.Generic;
using System.Threading;
using Es0203_Console.Classes;

namespace Es0203_Console
{
    class Program
    {
        public static List  <Cliente> qu= new List <Cliente>();
        public static List <Thread> th = new List<Thread>();
        static Barbiere b;
        static Negozio n;
        
        static void Main(string[] args)
        {
           
            n = new Negozio();
            b = new Barbiere(n);
            Thread barber = new Thread(()=>b.Addormentato());
            barber.Start();
            for(int i = 0; i < 10; i++)
            {
                int k = i;
                qu.Add(new Cliente(n, i));
                th.Add(new Thread(()=>qu[k].Entrata()));
                th[i].Start();
            }
            barber.Start();



        }

      
        
    }
}
