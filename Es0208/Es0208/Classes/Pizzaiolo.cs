using System;
using System.Collections.Generic;
using System.Text;

namespace Es0208.Classes
{
    class Pizzaiolo
    {
        Pizzeria p;

        public Pizzaiolo(Pizzeria l)

        {

            this.p = l;
        }

        public void Lavora()
        {
            p.Sforna();
        }
    }
}
