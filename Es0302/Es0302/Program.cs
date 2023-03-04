using System;

namespace Es0302
{
    class Program
    {
        static Pila<int> pil = new Pila<int>();
        static void Main(string[] args)
        {

            string exp = "12*45-2*";
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
                        pil.Push(Convert.ToInt32(c[i]-'0'));
                        
                        break;
                    case '+':
                        int sum=pil.Pop();
                        for(int j = 0; j < pil.aTop; j++)
                        {
                            
                            sum += pil.Pop();
                            
                        }
                        
                        pil.Push(sum);

                        break;
                    case '-':
                        int diff = pil.Pop();
                        for (int j = 0; j < pil.aTop; j++)
                        {
                           
                            diff -= pil.Pop();
                        }
                        
                        pil.Push(diff);
                        break;
                    case '*':
                        int molt = pil.Pop();

                        for (int j = 0; j < pil.aTop; j++)
                        {

                            molt *= pil.Pop();
                            
                        }

                        pil.Push(molt);
                        break;
                    case '/':
                        int div = pil.Pop();
                        for (int j = 0; j < pil.aTop; j++)
                        {
                            
                            div /= pil.Pop();
                        }

                        pil.Push(div);
                        break;



                }
                

            }
        }



    }
}
