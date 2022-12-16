using System;
using static System.Console;

namespace Casarotto
{
    public class Console
    {

        public static void Errore()
        {
            WriteLine("Attenzione! Inserire i dati richiesti in modo corretto.");
        }


       

        
    }
    public class IntMtd
    {
         public int Check()
         {
                    bool m = false;
                    int n=0;
                    while (!m)
                    {
                        string g = ReadLine();
                        m = Int32.TryParse(g, out n);
                        if (!m||n==0 && g!="0")
                        {
                            Console.Errore();
                            m = false;
                        }
                    }
                    return n;
         }
       


    }
}
