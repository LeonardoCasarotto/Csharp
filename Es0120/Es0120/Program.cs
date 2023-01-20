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
            for (int i = 0; i < rows; i++)
            {
                int local = i;
                threads[i] = new Thread(() => somma(local));
                threads[i].Start();
            }
            for (int i = 0; i < rows; i++)
            {
                threads[i].Join();
            }
            
            Console.WriteLine("Il risultato della somma uguale a "+som());
            
            Console.WriteLine("\nEND");
            


            

        }

        static void FillRandom()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = new Random().Next(1, 10);
                }
            }

        }
        static void somma(int index)
        {

            int temp = 0;
            for (int i = 0; i < cols; i++)
            {
                 temp+= matrix[index, i];
            }
            somme[index] = temp;
                
                
            
            
            
        }


        static int som()
        {
            int temp = 0;
            for(int i = 0; i < somme.Length; i++)
            {
                temp += somme[i];
            }
            return temp;
        }
    }
}
