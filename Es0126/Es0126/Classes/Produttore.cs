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
                Thread.Sleep(sleep.Next(0, 35000));
                sharedloc.Buffer = i;

            }

            Console.WriteLine();
        }
        

        




    }
}
