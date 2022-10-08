using System;
using static System.Console;
namespace Es0610
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 9, 8, 6, 7, 1, 0, 67 };
            int left = 0;
            int right = a.Length - 1;
            int center = a.Length / 2;

            a = Merge(a, left, right);
            for(int i = 0; i < a.Length; i++)
            {
                WriteLine(a[i]);
            }

        }


       
        static int[] Merge(int[] arr, int left, int right)
        {
            if (left > right)
            {
                return arr;
            }
            int mid = (left + right) / 2;
            Merge(arr, left, right);
            Merge(arr, mid + 1, right);
           
        
        
        }
    }
}
