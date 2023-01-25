using System;
using System.Threading;

namespace Es0123
{
    class Program
    {


        static int rows, cols,col;
        
        static int[,] matrix,matrice,risultato;
        static Thread[] threads;
        static void Main(string[] args)
        {
           
            Console.WriteLine("Inserire il numero di righe:");
            rows= int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il numero di colonne:");
            cols = int.Parse(Console.ReadLine());

            matrix = new int[rows, cols];


            Console.WriteLine("Inserire il numero di colonne:");
            col = int.Parse(Console.ReadLine());
            matrice = new int[cols, col];

            risultato = new int[rows, col];
            threads = new Thread[rows];
            for(int i = 0; i < rows; i++)
            {
                int rowIndex = i;
                threads[i] = new Thread(() => prodotto(rowIndex));
                threads[i].Start();
            }
            for(int i=0;i<rows; i++)
            {
                threads[i].Join();
            }


            Console.WriteLine("La matrice risultato uguale a ");
            stampa();



        }

       
        static void prodotto(int rowIndex)
        {

            for (int i = 0; i < col; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[rowIndex, j] * matrice[j, i];
                }
                risultato[rowIndex, i] = sum;
            }
        }
        static void stampa()
        {
            
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(risultato[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
