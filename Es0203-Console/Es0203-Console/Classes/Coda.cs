using System;
using System.Collections.Generic;
using System.Text;

namespace Es0203_Console.Classes
{
    public class  Negozio
    {

        bool barbieredormiente = false;
        int nocli = 0;
        readonly object locker = new object();
        readonly object lk = new object();

        
        

        public void NewCli()
        {
            lock (locker)
            {
                if (nocli > 0)
                {
                    nocli++;
                    Console.WriteLine("Cliente " +nocli+" entra");
                }
                else
                {
                    if (barbieredormiente)
                    {
                        barbieredormiente = false;
                        Console.WriteLine("Il barbiere è stato svegliato");
                    }
                    nocli--;

                }
            }
        }
        public void Sleep() 
        {

            lock (lk)
            {

                if (nocli < 1)
                {
                    Console.WriteLine("il barbiere sta dormendo");
                    barbieredormiente = true;
                }








            }
        
        
        
        
        
        
        
        }



    }
}
