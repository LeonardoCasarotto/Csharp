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
        public event EventHandler DoppiaTesta;
        public event EventHandler TriplaCroce;

        public int Lancia()
        {

            Random rn = new Random();
            int m =rn.Next(0, 2);

            if (memoria[0] == 0 && m == 0)
            {
                OnDoppiaTesta();
            }
            else if(memoria[0]==1 && memoria[1] == 1 && m == 1)
            {
                OnTriplaCroce();
            }


            memoria[0] = memoria[1];
            memoria[1] = m;

            return m;
        }

       



        // the name of the method must be On+event name, the signature protected virtual void.
        protected virtual void OnDoppiaTesta()
        {

            
           if(DoppiaTesta != null)
            {
                DoppiaTesta(this, EventArgs.Empty);
               
            }
        }

        protected virtual void OnTriplaCroce()
        {
            if(TriplaCroce != null)
            {
                TriplaCroce(this, EventArgs.Empty);

            }
        }

    }
}
