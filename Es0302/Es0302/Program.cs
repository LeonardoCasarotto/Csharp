using System;

namespace Es0302
{
    class Program
    {
        static Pila<string> pil = new Pila<string>();
        static void Main(string[] args)
        {
            string exp = "12*45-+2";

            sel(exp);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(pil.Pop());
            }
            






        }


        static void sel(string c)
        {
            int posizia = 0;

            for(int i = 0; i < c.Length-1; i++)
            {
                if (c[i] == '+' || c[i] == '-' || c[i] == '*' || c[i] == '/')
                {
                    if (posizia!=i)
                    {
                        pil.Push(c.Substring(posizia, i));
                        posizia = i + 1;
                    }
                }
            }
        }



    }
}
