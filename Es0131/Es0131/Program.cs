using System;
using System.Threading;
using Es0131.Classes;

namespace Es0131
{
    class Program
    {
        static BufferCondiviso[] garage;
        static Random rnd;
        static int ids;
        static void Main(string[] args)
        {
            ids = 0;
            Console.WriteLine("Benvenuti, inserire il numero di veicoli che si desidera vengano contenuti nel garage:");
            int lg = int.Parse(Console.ReadLine());
            garage = new BufferCondiviso[lg];

            for(int i = 0; i < lg; i++)
            {
                //todo costruttore vuoto
            }
            
        }
    }
}
