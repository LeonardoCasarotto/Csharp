using System;
using static System.Console;
using System.Threading;

namespace Es0118C
{
    class Program
    {
        static int A, B, C, D, E, F,G,H;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Proc1);
            Thread t2 = new Thread(Proc2);
            t1.Start();
            t2.Start();

            A = 10;
            D = A + 5;
            Console.WriteLine("D="+D);
            t1.Join();
            G = E - D;
            Console.WriteLine("G="+G);
            t2.Join();
            H = F + G;
            Console.WriteLine("G="+G);
        }
        static void Proc1()
        {
            B = 20;
            E = B * 2;
            Console.WriteLine("E="+E);

        }
        static void Proc2()
        {
            C = 30;
            F = C * C;
            Console.WriteLine("F="+F);
        }
    }
}
