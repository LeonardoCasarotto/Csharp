using System;
using static System.Console;
using System.Threading;

namespace Es0119B
{
    class Program
    {
        static int[] array;
        static int[] res;
        static void Main(string[] args)
        {
            //filling the array
            array = new int[10000];
            res = new int[4];

            for (int i = 0; i < 10000; i++)
            {
                array[i] = new Random().Next(1, 100001);
            }

            Thread t1 = new Thread(() => Verifica(0, 0));
            Thread t2 = new Thread(() => Verifica(2500, 1));
            Thread t3 = new Thread(() => Verifica(5000, 2));
            Thread t4 = new Thread(() => Verifica(7500, 3));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();

            Console.WriteLine("Valori singoli dei quattro sottoarray:");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(i+1+".\t MAX:"+res[i]);
            }
            
            res = Bubble(res);
            Console.WriteLine("Il valore massimo risulta dunque essere "+res[res.Length-1]);
            Console.WriteLine("\nEND");
        }

        static void Verifica(int first, int val)
        {
            int[] secondary = new int[2500];
            for (int i = 0; i < 2500; i++)
            {
                secondary[i] = array[first + i];
            }
            //sorting with bubble sort algorithm
            secondary = Bubble(secondary);
            res[val] = secondary[secondary.Length - 1];
        
        }

        static int[] Bubble(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
                for (int i = 0; i < arr.Length - 1; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
            return arr;
        }
    }
}
