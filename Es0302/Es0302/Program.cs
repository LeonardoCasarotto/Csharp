using System;

namespace Es0302
{
    class Program
    {
        static Pila<int> pil = new Pila<int>();
        static void Main(string[] args)
        {

            string exp = "5 9 8 + 4 6 * * 7 + * ";
            Console.WriteLine("Espressione di partenza :\n"+exp);
            sel(exp);

            for(int i = 0; i < pil.aTop ; i++)
            {
                Console.WriteLine("Il risultato uguale a :");
                Console.WriteLine(pil.Pop());
            }
            






        }


        static void sel(string c)
        {
            int posizia = 0;


            for(int i = 0; i < c.Length; i++)
            {

                switch (c[i])
                {
                    default:
                        int num = 0;
                        while (i < c.Length && c[i] >= '0' && c[i] <= '9')
                        {
                            num = num * 10 + (int)(c[i] - '0');
                            
                            i++;
                        }
                        i--;
                        Console.WriteLine(num);
                        pil.Push(num);
                        break;

                    case ' ':
                        break;

                    case '+':
                        int sum = pil.Pop();
                        sum += pil.Pop();
                        pil.Push(sum);
                        break;

                    case '-':
                        int b = pil.Pop();
                        int a = pil.Pop();
                        int diff = a - b;
                        pil.Push(diff);
                        break;

                    case '*':
                        int prod = pil.Pop();
                        prod *= pil.Pop();
                        pil.Push(prod);
                        break;

                    case '/':
                        b = pil.Pop();
                        a = pil.Pop();
                        int div = a / b;
                        pil.Push(div);
                        break;
                }


            }
        }



    }
}
