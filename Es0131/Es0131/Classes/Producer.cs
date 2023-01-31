using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0131.Classes
{
    public class Producer
    {
        BufferCondiviso[] garage;
        Random time;
        int id = 0;

        public Producer(BufferCondiviso[] bf, Random tim)
        {
            garage = bf;
            this.time = tim;

        }

        public  void Produce()
        {
           for(int i = 0; i < garage.Length; i++)
            {
                garage[i].macchina = new Auto(id);
                id++;
                Thread.Sleep(time.Next(0, 2000));
            }
        }
    }
}
