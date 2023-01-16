using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace Es0116.Classes
{
    public class Eggs
    {
        
        public static void Rottura()
        {
            Console.WriteLine("Le uova sono state rotte, ed ora si trovano dentro la pentola");

            Thread.Sleep(2000);
            Console.WriteLine("Le uova si stanno cuocendo...");
            Thread.Sleep(3000);
            Console.WriteLine("Le uova sono cotte, e si stanno posizionando nel piatto");
            Thread.Sleep(0);
        }
    }
}
