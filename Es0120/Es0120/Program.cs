using System;
using System.Threading;
using static System.Console;


namespace Es0120
{
    class Program
    {
        static int rows;
        static int cols;
        static Thread[] threads;
        static int[,] matrix;
        static int[] somme;
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuti, inserire il numero di righe");
            int.TryParse(ReadLine(), out rows);
            Console.WriteLine("Inserire ora il numero di colonne");
            int.TryParse(ReadLine(), out cols);
            matrix = new int[rows, cols];
            FillRandom();
            threads = new Thread[rows];
            somme = new int[rows];
            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine("Row"+i);
                threads[i] = new Thread(() => somma(i));
            }
            for(int i = 0; i < rows; i++)
            {
                threads[i].Start();
            }
            for(int i = 0; i < rows; i++)
            {
                threads[i].Join();
            }
            int s = tot();
            Console.WriteLine("Il risultato della somma uguale a "+s);
            Console.WriteLine("\n END");
            


            

        }

        static void FillRandom()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = new Random().Next(1, 100000);
                }
            }

        }
        static void somma(int index)
        {
            int somma = 0;
            for(int i = 0; i < cols; i++)
            {
                somma +=matrix[index, i];
            }
            somme[index] = somma;
        }
        static int tot()
        {
            int m = 0;
            for(int i = 0; i < somme.Length; i++)
            {
                m += somme[i];
            }
            return m;
        }
    }
}
