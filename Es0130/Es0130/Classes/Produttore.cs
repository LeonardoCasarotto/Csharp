using Es0130.Classes.CThreadWaitPulse_base;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Es0130.Classes
{
    public class Produttore
    {
        static char[] parola;
        static BufferCondiviso[] arr;
        static Random Wait;
        public Produttore(string wrd, BufferCondiviso[] array, Random w)
        {
            parola = wrd.ToCharArray();
            arr = array;
            Wait = w;
            
        }

        public void Produce()
        {
            for(int i = 0; i < parola.Length; i++)
            {
                Thread.Sleep(Wait.Next(0, 2000));

                arr[i % arr.Length].Buffer = parola[i];

                
            }
        }


    }
}
