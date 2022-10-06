using System;
using static System.Console;

namespace Ricorsione
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] z = { 1, 2, 3,3, 4, 5, 6, 7, 8, 9 };
            /*z = inverti(z, 0, 8);
            for(int i = 0; i < z.Length; i++)
            {
                WriteLine(z[i]);
            }*/

            WriteLine(conta(z, 0, 8, 3));
        }


       static int[] inverti(int[] arr,int from,int to)
        {
           
            if (to<=from)
            {
                return arr;
            }
            else
            {

                int temp = arr[from];
                arr[from] = arr[to];
                arr[to] = temp;
                return inverti(arr, from+1, to-1);
            }

        }
        static int conta(int[] arr, int from, int to, int n)
        {
            if (to <= from)
            {
                return 0;
            }
            else if (arr[from] == n)
            {
                return 1 + conta(arr, from + 1, to, n);
            }
            else
                return conta(arr, from + 1, to, n);



        }
    }
}
