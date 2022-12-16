using System;
using System.Collections.Generic;
using System.Text;

namespace Es1117.Classes
{
    public class CAuto : IGuida, IPieno
    {
        int benzina;
        int maxbenz;
        public CAuto(int benz, int max)
        {
            benzina = benz;
            maxbenz = max;
        }
        
        public void Drive()
        {


        }



        public bool Refuel(int qty)
        {
            if (qty > 1)
            {
                benzina += qty;
                if (benzina > maxbenz) benzina = maxbenz;
                return true;
            }
            else return false;

        }
        

    }
}
