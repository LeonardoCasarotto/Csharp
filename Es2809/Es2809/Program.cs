using System;
using static System.Console;
namespace Es2809
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 7, 4, 3, 10, 3 };

            WriteLine(myfunc(arr, 0, 5, 3));


        }

        static int myfunc(int[] arr, int start, int end, int x)
        {
            if (start == end+1)
            {
                return 0 ;
            }
            if (arr[start] == x)
            {
                return 1 + (myfunc(arr, start + 1, end, x));
            }

            else
            {
                return (myfunc(arr, start + 1, end, x));
            }
        }
        
    }
}
