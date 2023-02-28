using System;
using System.Collections.Generic;
using System.Linq;
using Es0228.Classes;

namespace Es0228
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string one = "{3+[4*(15/3)]}";
            Eval(one);

            string two = "{55/5+42-[7*45/(14/2)+[5+22]}";
            Eval(two);


            
        }

        static void Eval(string input)
        {
            int[] tonde = new int[2];

            int[] quadre = new int[2];
            int[] graffe = new int[2];
            for (int i = 0; i < 2; i++)
            {
                tonde[i] = 0;
                quadre[i] = 0;
                graffe[i] = 0;
            }
            Pila<char> operazioni = new Pila<char>();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '{':
                        operazioni.Push(input[i]);
                        break;
                    case '}':
                        operazioni.Push(input[i]);
                        break;
                    case '[':
                        operazioni.Push(input[i]);
                        break;
                    case ']':
                        operazioni.Push(input[i]);
                        break;
                    case '(':
                        operazioni.Push(input[i]);
                        break;
                    case ')':
                        operazioni.Push(input[i]);
                        break;
                    default:
                        break;
                }
            }


            while (!operazioni.isEmpty())
            {
                switch (operazioni.Pop())
                {
                    case '{':
                        graffe[0]++;
                        break;
                    case '}':
                        graffe[1]++;
                        break;
                    case '[':
                        quadre[0]++;
                        break;
                    case ']':
                        quadre[1]++;
                        break;
                    case '(':
                        tonde[0]++;
                        break;
                    case ')':
                        tonde[1]++;
                        break;
                    default:
                        break;
                }
            }

            if (graffe[0] == graffe[1] && quadre[0] == quadre[1] && tonde[0] == tonde[1])
            {
                Console.WriteLine("L'espressione " + input + "\nè scritta in modo corretto");
            }
            else Console.WriteLine("l'espressione " + input + "\nè scritta in modo errato");

        }



    }


}
