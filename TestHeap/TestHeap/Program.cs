using System;

namespace TestHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap<Uccellino> ciao = new MinHeap<Uccellino>(250);
            Console.WriteLine("CREATO HEAP");

            ciao.Insert(new Uccellino(5, 10));

            ciao.Tipo();
        }
    }
}
