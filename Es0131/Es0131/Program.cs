using System;
using System.Threading;
using Es0131.Classes;

namespace Es0131
{
    class Program
    {
        static BufferCondiviso[] garage;
        static Random rnd;
            
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuti, inserire il numero di veicoli che si desidera vengano contenuti nel garage:");
            int lg = int.Parse(Console.ReadLine());
            garage = new BufferCondiviso[lg];
            rnd = new Random();

            for(int i = 0; i < lg; i++)
            {
                garage[i] = new BufferCondiviso();
            }

            Producer prd = new Producer(garage, rnd);
            Consumer cns = new Consumer(garage, rnd);


            Thread producer = new Thread(() => prd.Produce());
            Thread consumer = new Thread(() => cns.Consume());

            producer.Start();
            consumer.Start();

            producer.Join();
            consumer.Join();




            
        }
    }
}
