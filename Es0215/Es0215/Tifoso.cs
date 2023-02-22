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
        int id;

        public Tifoso(Bar b, Tipo s, int i)
        {
            this.locale = b;
            this.squadra = s;
            this.id = i;
            
        }
        public Tipo getSquadra()
        {
            return this.squadra;
        }
        public int getId()
        {
            return this.id;
        }

        public void Pausa()
        {
            locale.EntrataCliente(this);
        }
    }
}
