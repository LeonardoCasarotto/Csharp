using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es0215_Form.Classes
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
