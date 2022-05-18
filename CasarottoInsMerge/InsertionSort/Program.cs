using System;
using static System.Console;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool m = false;
                int n = 0;
                WriteLine("Inserire 1 per l'insertion sort, 2 per il merge sort e 3 per uscire");
                while (!m)
                {
                    m = int.TryParse(ReadLine(), out n);
                    if (!m)
                    {
                        WriteLine("inserire correttamente");
                    }
                }
                switch (n)
                {

                    case 1:
                        Insertion();
                        break;
                    case 2:
                        Merge();
                        break;
                    case 3:
                        return;
                }



                



            }
            static void Insertion()
            {
                int n;
                bool test = false;
                do
                {
                    Console.WriteLine("Enter the number of elements in the array");
                    test = int.TryParse(Console.ReadLine(), out n);
                    if (!test)
                    {
                        Console.WriteLine("Invalid input");
                    }
                } while (!test);

                string[] stringhe = new string[n];



                for (int i = 0; i < stringhe.Length; i++)
                {
                    Console.WriteLine("Enter the element");
                    stringhe[i] = Console.ReadLine();
                    for (int j = 0; j < i; j++)
                    {
                        if (stringhe[i].CompareTo(stringhe[j]) < 0)
                        {
                            string temp = stringhe[i];
                            stringhe[i] = stringhe[j];
                            stringhe[j] = temp;
                        }
                    }
                }
                WriteLine("----------------------------------------------------");
                for (int i = 0; i < stringhe.Length; i++)
                {
                    Console.WriteLine(stringhe[i]);
                }
            }
            static void Merge()
            {
                bool m = false;
                int n = 0;
                while (!m)
                {

                    WriteLine("Enter the number of elements in the array");
                    m = int.TryParse(ReadLine(), out n);
                    if (!m)
                    {
                        WriteLine("Invalid input");
                    }
                }
                m = false;
                int[] v1 = new int[n];
                for (int l = 0; l < v1.Length; l++)
                {
                    WriteLine("Enter the element");
                    m = int.TryParse(ReadLine(), out v1[l]);

                }
                int[] v2 = new int[n];
                for (int l = 0; l < v2.Length; l++)
                {
                    WriteLine("Enter the element");
                    m = int.TryParse(ReadLine(), out v2[l]);


                    int contatore = 0;
                    int[] v3 = new int[v1.Length + v2.Length];


                    int i = 0;
                    int j = 0;

                    while (i < v2.Length && j < v1.Length)
                    {
                        if (v1[j] < v2[i])
                        {
                            v3[contatore] = v1[j];

                            j++;
                        }
                        else
                        {
                            v3[contatore] = v2[i];

                            i++;
                        }
                        contatore++;
                    }
                    if (i < v2.Length)
                    {
                        while (i < v2.Length)
                        {
                            v3[contatore] = v2[i];
                            i++;
                            contatore++;
                        }
                    }
                    else if (j < v1.Length)
                    {
                        while (j < v1.Length)
                        {
                            v3[contatore] = v1[j];
                            j++;
                            contatore++;
                        }

                    }

                    WriteLine("---------------------");
                    for (int k = 0; k < v3.Length; k++)
                    {
                        WriteLine(v3[k]);
                    }
                }

            }
        }
    }
}