using System;

namespace TestHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap ciao = new MinHeap(250);
            ciao.Inserisci(new Uccellino(0, 20));
            ciao.Inserisci(new Uccellino(1, 12));
            ciao.Inserisci(new Uccellino(2, 150));
            ciao.Inserisci(new Uccellino(3, 4));

            ciao.PrintHeapGraphically();




            Console.WriteLine("\n\n\n");
            ciao.RemoveRight();
            ciao.PrintHeapGraphically();



        }
    }
}
