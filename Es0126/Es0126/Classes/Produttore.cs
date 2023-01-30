using Es0126.Classes.CThreadWaitPulse_base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Es0126.Classes
{
    class Produttore
    {

        private BufferCondiviso sharedloc;
        private Random sleep;

        public Produttore(BufferCondiviso shrd, Random rnd)
        {
            sharedloc = shrd;
            sleep = rnd;
        }


        public void Produce()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for(int i = 0; i <= 4; i++)
            {
                Thread.Sleep(sleep.Next(0, 3000));
                sharedloc.Buffer = i;

            }

            Console.WriteLine();
        }
        


    }
    public class Consumatore
    {
        private BufferCondiviso sharedloc;
        private Random sleep;
        private int somma;

        public Consumatore(BufferCondiviso bf, Random rnd)
        {
            this.sharedloc = bf;
            this.sleep = rnd;
            this.somma = 0;

        }

        public void Consume()
        {
            for(int i = 0; i <= 4; i++)
            {
                Thread.Sleep(sleep.Next(0, 3000));
                somma += sharedloc.Buffer;
                
            }
            Console.WriteLine("Il risultato della somma uguale a "+somma);
        }
    }
}
