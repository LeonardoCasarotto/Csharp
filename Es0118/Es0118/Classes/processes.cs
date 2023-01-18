using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace Es0118.Classes
{
    public class processes
    {
        public static void ThreadA()
        {
            WriteLine("Thread_A Start\n");
            for(int j = 0; j < 100; j++)
            {
                Write("A");
            }
            ReadKey();
        }






    }
}
