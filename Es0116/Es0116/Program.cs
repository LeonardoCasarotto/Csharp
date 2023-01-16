using System;
using System.Threading;
using Es0116.Classes;

namespace Es0116
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread egg = new Thread(new ThreadStart(Eggs.Rottura));
            Thread ham = new Thread(new ThreadStart(Prosciutto.Reperimento));
            egg.Start();
            ham.Start();
            egg.Join();
            Console.WriteLine("End");
            
        }
    }
}
