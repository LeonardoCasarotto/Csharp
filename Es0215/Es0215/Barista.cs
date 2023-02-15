using System;
using System.Collections.Generic;
using System.Text;

namespace Es0215
{
    class Barista
    {
        Bar locale;
        

        public Barista(Bar b)
        {
            this.locale = b;
        }

        public void Servi()
        {
            locale.BarInFunzione();
        }



    }
}
