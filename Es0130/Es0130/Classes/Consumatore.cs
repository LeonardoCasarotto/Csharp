using Es0130.Classes.CThreadWaitPulse_base;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace Es0130.Classes
{
    public class Consumatore
    {

        static BufferCondiviso[] arr;
        static Random wait;
        static string parola;
        int l;

        public Consumatore( BufferCondiviso[] array, Random w, int lg)
        {     
            arr = array;
            wait = w;
            parola = "";
            l = lg;
        }

        public void Consume()
        {
            for (int i = 0; i < l; i++)
            {
                Thread.Sleep(wait.Next(0, 2000));
                parola += arr[i % arr.Length].Buffer;

            }
            Console.WriteLine("\n\nLa parola corrisponde a  " + parola);
        }






    }
}
