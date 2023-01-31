using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0131.Classes
{
    public class Consumer
    {
        BufferCondiviso[] garage;
        Random rnd;
        

        public Consumer(BufferCondiviso[] bf, Random rn)
        {
            garage = bf;
            rnd = rn;
        }


        public void Consume()
        {
            for (int i = 0; i < garage.Length; i++)
            {
                Auto temp = garage[i].macchina;
                Thread.Sleep(rnd.Next(0, 2000));
            }
        }

    }
}
