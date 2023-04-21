using System;

namespace TestHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            MinHeap ciao = new MinHeap(250);
            for (int i = 0; i < 10; i++)
                ciao.Inserisci(new Uccellino(0, rnd.Next(0,1000)));


            int[] arr = ciao.Arr();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }




            



        }
    }
}
