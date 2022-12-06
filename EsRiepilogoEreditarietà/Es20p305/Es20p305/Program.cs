using System;
using static System.Console;
namespace Es17p303
{
 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Atleta ciao;
            ciao = new Nuotatore("Luigi", "peruviano", 3, 1996,"rana", 3, 6);

            WriteLine(((Nuotatore)ciao).Nuota());
        }
    }
}
