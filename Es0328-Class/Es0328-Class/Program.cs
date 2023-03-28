using System;

namespace Es0328_Class
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Testing the queue");

            CQueue<string> coda = new CQueue<string>();

            coda.Enqueue("primo elemento inserito");
            Console.WriteLine("ho inserito");
            Console.WriteLine(coda.Front());
            Console.WriteLine(coda.IsEmpty());
            Console.WriteLine(" estraggo elemento " + coda.Dequeue());
            Console.WriteLine(coda.IsEmpty());

        }

    }
}
