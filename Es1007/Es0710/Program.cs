using System;
using static System.Console;

namespace Es0710
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi(4, 'A', 'B', 'C');
        }
        static void Hanoi(int n, char from, char to, char current )
        {
            //caso base
            if (n == 1)
            {
                WriteLine("Disco 1 spostato da " + from + " a " + to);
                return;
            }
            Hanoi(n - 1, from, current,to);
            WriteLine("Disco " + n + " spostato da " + from + " a " + to);
            Hanoi(n - 1, current, to, from);
        }
    }
}
