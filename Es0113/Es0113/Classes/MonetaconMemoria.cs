using System;
using System.Collections.Generic;
using System.Text;

namespace Es0113.Classes
{
    public class MonetaconMemoria:Lancio
    {
        private int[] memoria;
        
        public MonetaconMemoria()
        {
            memoria = new int[2];
            memoria[0]=9;
            memoria[1] = 9;

        }

        public int Lancia()
        {

            Random rn = new Random();
            int m =rn.Next(0, 2);

            if (memoria[0] == 0 && m == 0)
            {
                //aderisci a doppiatesta
            }
            else if(memoria[0]==1 && memoria[1] == 1 && m == 1)
            {
                //aderisci a triplacroce
            }
            //todo cambiomemoria

            return m;
        }
        /*
        public event DoppiaTesta;
        public event TriplaCroce;*/
        
    }
}
