using System;
using System.Collections.Generic;
using System.Text;

namespace Es1117.Classes
{
    public class CAereo:IVola, IPieno
    {
        int carburante;
        int maxcarburante;

        public CAereo(int carb)
        {
            if (carb > 1)
            {
                carburante = carb;
                if (carburante > maxcarburante) carburante = maxcarburante;
                
            }
            else
            {

                carburante = 0;
            }
            
            

        }

        public bool Decolla()
        {
            return true;
        }
        public bool Atterra() 
        {
            return true;
        }

        public bool Refuel(int qty)
        {
            if (qty > 1)
            {
                carburante += qty;
                if (carburante > maxcarburante) carburante = maxcarburante;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
