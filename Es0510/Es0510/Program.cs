using System;

namespace Es0510
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(matrice(3, 3));
        }
        
        static int matrice(int r, int c)
        {
            //caso base
            if (r == 1 || c == 1) 
                return 1;


            else
                return (matrice(r - 1, c) + matrice(r, c - 1));
        }
    }
}
