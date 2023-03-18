using System;

namespace Es0318
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList<int> lista = new LinkedList<int>();
            Random n = new Random();

            Console.WriteLine("Riempio la lista");

            for (int i = 0; i < 20; i++)
            {
                int m = n.Next(0, 1000);
                lista.Add(m);
                Console.WriteLine("Aggiungo alla lista il numero " + m);
            }
            
            Console.WriteLine("Rimuovo il primo elemento");
            lista.RemoveAt(0);

            Console.WriteLine("Rimuovo l'ultimo elemento ");
            lista.RemoveAt(lista.Length);


            Console.WriteLine("Rimuovo l'elemento che si trova a metá della lista");

            lista.Add(46);


            Console.WriteLine(lista.Length);


            Console.WriteLine("É presente il numero 46 ? Verifico...");

            if (lista.Contains(46) == true) Console.WriteLine("Il numero 46 é presente nella lista!");

            else Console.WriteLine("Il numero 46 non é presente nella lista");


            



        }
    }
}
