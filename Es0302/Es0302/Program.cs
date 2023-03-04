using System;

namespace Es0302
{
    class Program
    {
        static Pila<char> pil = new Pila<char>();
        static void Main(string[] args)
        {
            string exp = "12*45-2*";

            sel(exp);

            for(int i = 0; i < pil.aTop ; i++)
            {
                Console.WriteLine(pil.Pop());
            }
            






        }


        static void sel(string c)
        {
            int posizia = 0;

            for(int i = 0; i < c.Length; i++)
            {
                switch(c[i];:

            }
        }



    }
}
