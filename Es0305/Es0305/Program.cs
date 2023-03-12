using System;
using System.Collections;
using System.Collections.Generic;

namespace Es0305
{
    class Program
    {
        static void Main(string[] args)
        {
            int same = 0;
            int[,] matrice = { { 0, 1, 0 }, { 0, 0, 0 }, { 0, 1, 0 } };
            Stack<int> pila = new Stack<int>();
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (matrice[i, j] == 1&&i!=j)
                    {
                        bool vip = true;

                        for(int m = 0; m < 3; m++)
                        {
                            if (matrice[j, m] == 1)
                            {
                                vip = false;
                                break;
                            }
                            
                        }
                        if (vip) pila.Push(j);
                    }

                }
            }
            if (pila.Count == 0) Console.WriteLine(-1);
            else Console.WriteLine(1);

           


        }
    }
}
