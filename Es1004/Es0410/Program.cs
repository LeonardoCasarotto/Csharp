using System;

namespace Es0410
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Amicizie(0));
        }

        static  int Amicizie(int n)
        {


            if (n <= 1)
                return 0;
            else
                n--;
                return n + Amicizie(n);


        }
    }
}
