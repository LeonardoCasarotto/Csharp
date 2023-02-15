using System;
using System.Collections.Generic;
using System.Text;

namespace Es0215
{
    enum Tipo { locale,ospite}
    class Tifoso
    {
        Bar locale;
        Tipo squadra;

        public Tifoso(Bar b, Tipo s)
        {
            this.locale = b;
            this.squadra = s;
        }


        public void Pausa()
        {
            locale.EntrataCliente();
        }
    }
}
