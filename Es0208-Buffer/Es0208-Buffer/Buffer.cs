using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0208_Buffer
{
    public class shrdBuffer
    {
        public int buffer=-1;
        static int readwrite = 0;
        //se valore uguale a zero deve essere scritto
        //se valore uguale a uno deve essere letto
        static object _locker = new object();

        
        public void SetBuffer(int z)
        {
            lock (_locker)//blocco l'oggetto
            {
                
                if (readwrite==1)//se il valore è stato scritto
                {
                    Monitor.Wait(_locker);
                }
                Console.WriteLine("Scrivo");
                --readwrite; //il valore è stato letto
                buffer = z;
                Monitor.Pulse(_locker);

            }

        }

        public int GetBuffer()
        {
            
          
            int copia;
            lock (_locker)
            {
                if (readwrite==0)//se  il valore è stato letto
                {

                    Monitor.Wait(_locker);
                }
                Console.WriteLine("leggo");
                ++readwrite;// il valore è stato scritto
                copia = buffer;
                Monitor.Pulse(_locker);                
            }
            return buffer;
        }
       
    }
    

}

