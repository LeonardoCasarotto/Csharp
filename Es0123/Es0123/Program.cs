using System;
using System.Threading;

namespace Es0123
{
    class Program
    {


        static int rows, cols;
        static int[,] matrix,matrice;
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il numero di righe:");
            rows= int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il numero di colonne:");
            cols = int.Parse(Console.ReadLine());

            matrix = new int[rows, cols];




        }
    }
}
