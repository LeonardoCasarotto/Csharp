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
            Stack<Vip> pila = new Stack<Vip>();
            for(int i = 0; i < matrice.GetLength(1); i++)//colonna
            {
                int con = 0;
                bool vip = true;
                for (int j = 0; j < matrice.GetLength(0); j++)//riga
                {
                    //verifico se in ciascuna riga della colonna se un valore è uguale a 1
                    
                    if (matrice[j,i] ==1)
                    {
                        con++;
                        //ho trovato una persona ne conosce un'altra
                        
                        for(int m = 0;m < matrice.GetLength(0);m++) 
                        {
                            
                            if (matrice[i, m] == 1)
                            {
                                
                                vip = false;
                                break;
                            }


                        }
                        

                    }

                }
                
                if (vip)
                {


                    pila.Push(new Vip(i, con));

                }
            }
            if (pila.Count == 0) Console.WriteLine(-1);
            else
            {
                Console.WriteLine(pila.Count);
                foreach(Vip v in pila)
                {
                    if(v.followers>0)Console.WriteLine("Il vip a riga "+v.riga+" è conosciuto da "+v.followers+" persone");
                }
            }

           


        }
    }
}
