using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0208_Buffer
{ 
    class Produttore
    {
        shrdBuffer b;
        Random rnd;
        public Produttore(shrdBuffer p) 
        {
            this.b = p;
            rnd = new Random();
        }

        public void Produce()
        {
            for(int i = 0; i <= 4; i++)
            {
                Thread.Sleep(rnd.Next(0, 2000));
                b.SetBuffer(i);
                
            }
        }
    }
}
