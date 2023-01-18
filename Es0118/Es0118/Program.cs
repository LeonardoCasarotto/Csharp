using System;
using System.Threading;
using System.Diagnostics;
using static System.Console;
using Es0118.Classes;
namespace Es0118
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a stopwatch
            Stopwatch watch = new Stopwatch();

            Thread tA = new Thread(processes.ThreadA);
            watch.Start();
            tA.Start();

            WriteLine("Thread_B Start\n");
            for(int j = 0; j < 100; j++)
            {
                Write("B");
                Thread.Sleep(10);
            }
            watch.Stop();
            WriteLine("\nExecution time: "+ watch.ElapsedMilliseconds);
         

            

        }
    }
}
