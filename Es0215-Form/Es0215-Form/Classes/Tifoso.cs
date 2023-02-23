using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es0215_Form.Classes
{
    public enum Tipo { locale, ospite }
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
