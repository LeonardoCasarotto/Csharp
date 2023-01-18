using System;
using static System.Console;
using System.Diagnostics;
using System.Threading;

namespace Es0118B
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = new Stopwatch();

            //Thread tmain = new Thread();
            clock.Start();
            for(int i = 0; i < 100; i++)
            {
                Write("A");
                Thread.Sleep(10);
            }
            Write("\n");
            for(int i = 0; i < 100; i++)
            {
                Write("B");
                Thread.Sleep(10);
            }
            clock.Stop();

            WriteLine("\nTempo trascorso uguale a " + clock.ElapsedMilliseconds+ "ms");
        }
    }
}
