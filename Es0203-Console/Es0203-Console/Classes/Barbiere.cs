using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0203_Console.Classes
{
    class Barbiere
    {
        barBuffer shared;
        



        public Barbiere(barBuffer neg)
        {
            
            shared = neg;

        }

        public void taglia_capelli()
        {
            shared.Servizio_Barbiere();//taglio dei capelli 
        }






    }
}
