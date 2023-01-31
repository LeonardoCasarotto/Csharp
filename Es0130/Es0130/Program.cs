using Es0130.Classes.CThreadWaitPulse_base;
using System;
using System.Threading;

namespace Es0130.Classes
{
    class Program
    {
        static BufferCondiviso[] shrlc;
        static string parola;
        static Produttore producer;
        static Consumatore consumer;
        static Random rn;

        static void Main(string[] args)
        {
            rn = new Random();
            shrlc = new BufferCondiviso[5];

            for(int i = 0; i < 5; i++)
            {
                shrlc[i] = new BufferCondiviso();
            }






            parola = "supercalifragilistichespiralidoso";
            producer = new Produttore(parola, shrlc, rn);
            consumer = new Consumatore(shrlc, rn, parola.Length);



            Thread prd = new Thread(() => producer.Produce());
            Thread cns = new Thread(() => consumer.Consume());
            prd.Start();
            cns.Start();

            prd.Join();
            cns.Join();


        }
    }
}
