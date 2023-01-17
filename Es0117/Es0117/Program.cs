using System;
using static System.Console;

namespace Es0117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuti, per iniziare inserire il valore iniziale del deposito bancario");
            bool test = false;
            decimal init = -1;
            while (!test)
            {
                test= Decimal.TryParse(ReadLine(), out init);
                if (!test || init < 0)
                {
                    throw new ArgumentOutOfRangeException("Attenzione! Inserire un valore superiore o uguale a zero.");
                }
                //TODO implement threads
                //TODO implement program
            }
        }


       
    }
}
