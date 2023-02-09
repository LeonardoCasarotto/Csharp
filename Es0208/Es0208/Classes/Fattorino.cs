using System;
using System.Collections.Generic;
using System.Text;

namespace Es0208.Classes
{
    class Fattorino { 

        Pizzeria p;

        public Fattorino(Pizzeria pizz)
        {
            p = pizz;
        }


        public void Lavora()
        {
            p.Consegna();
        }






    }
}
