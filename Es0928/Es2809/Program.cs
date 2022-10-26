using System;
using static System.Console;
using System.IO;
namespace Es2809
{
    class Program
    {
        static void Main(string[] args)


        {

            DateTime ciao = Convert.ToDateTime("17/08/2022");
            DateTime ciaz = Convert.ToDateTime("14/06/2025");

            WriteLine(ciao + "\n" + ciaz);
            WriteLine(DateTime.Compare(ciao, ciaz));
            WriteLine(DateTime.Compare(ciaz, ciao));



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
