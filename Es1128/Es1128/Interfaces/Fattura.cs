using System;
using System.Collections.Generic;
using System.Text;

namespace Es1128
{
    public class Fattura
    {
        DateTime data;
        DateTime scadenza;
        int numero;

        public Fattura(DateTime d, DateTime s, int n) {
        
        }
        protected  DateTime Scadenza();
        protected DateTime Data();
        protected bool Paga(){};
        
    }
}
