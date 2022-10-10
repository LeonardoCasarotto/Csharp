using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasarottoTestLampadina
{
    
    class Lampadina{
        //attributi
        private string stato;
        private int cicli;
        private const int MAX_CICLI = 10;


        //metodo costruttore
        public Lampadina()
        {
            this.stato = "off";
            this.cicli = 0;
        }

        //metodo modificatore

        public void Click(string stato,int cicli)
        {
            if (cicli<MAX_CICLI) {

                switch (this.stato)
                {
                      case "on":
                        this.stato = "off";
                        break;
                      case "off":
                        this.stato = "on";
                        break;
                }
                this.cicli++;
            
            }
            else
            {
                this.stato = "rotta";
            }
        }

        //metodo query
        public int Cicli()
        {
            return this.cicli;
        }
        public string Stato()
        {
            return this.stato;
        }


        








    }
}
