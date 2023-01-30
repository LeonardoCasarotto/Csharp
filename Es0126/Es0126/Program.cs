using Es0126.Classes.CThreadWaitPulse_base;
using System;
using System.Threading;


namespace Es0126.Classes
{
    class Program
    {
        static BufferCondiviso buf;
        static Random rn;
        static Produttore producer;
        static Consumatore consumer;
        static void Main(string[] args) {
            //initializing producer and consumer
            buf = new BufferCondiviso();
            rn = new Random();
            producer = new Produttore(buf, rn);
            consumer = new Consumatore(buf, rn);




            //declaring and assigning threads
            Thread prod = new Thread(() => producer.Produce());
            Thread cons = new Thread(() => consumer.Consume());

            prod.Start();
            cons.Start();

            prod.Join();
            cons.Join();



            
        }



        
    }
}
