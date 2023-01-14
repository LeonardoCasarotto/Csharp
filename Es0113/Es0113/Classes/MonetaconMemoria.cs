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
        
        
        //events handler --> servono?
        public static string DoppiaTesta_completed(object sender, EventArgs e)
        {
            return "Nella moneta è uscito due volte il valore testa";


        }

        public static string TriplaCroce_completed(object sender, EventArgs e)
        {
            return "Nella moneta è uscito tre volte il valore croce";
        }

        //eventi

        public event EventHandler DoppiaTesta;
        public event EventHandler TriplaCroce;





        protected virtual void OnProcessCompleted(EventArgs e)
        {
            DoppiaTesta?.Invoke(this, e);
        }
    }
}
