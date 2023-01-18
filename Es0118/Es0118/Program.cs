using System;
using System.Threading;
using static System.Console;
using Es0118.Classes;
namespace Es0118
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread tA = new Thread(processes.ThreadA);
            tA.Start();

            WriteLine("Thread_B Start\n");
            for(int j = 0; j < 100; j++)
            {
                Write("B");
            }
            tA.Join();

            

        }
    }
}
