using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0208_Buffer
{
    class Consumatore
    {
        Random rnd;
        shrdBuffer b;
        static int f;

        public Consumatore(shrdBuffer p)
        {
            this.b = p;
            rnd = new Random();
            f = 0;
        }

        public void  Consume()
        {
            for (int i = 0; i <= 4; i++)
            {
                Thread.Sleep(rnd.Next(0, 2000));
                f += b.GetBuffer();
                
            }
            Console.WriteLine("La somma uguale a "+f);
        }
    }
    
}
