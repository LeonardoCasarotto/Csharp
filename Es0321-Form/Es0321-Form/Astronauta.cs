using System;
using System.Collections.Generic;

namespace Es0321_Form
{
    public enum stato { pronto,inAddestramento }
    public enum ruolo { scienziato, pilota, copilota, capitano, elettricista }
    public  abstract class Astronauta
    {
        public ruolo role { get;}
        public List<int> missions { get; } // memorize missions ids
        public stato currentState { get;}

        public Astronauta(stato cr,ruolo rl)
        {

            missions = new List<int>();
            this.role = rl;
            this.currentState = cr;
            

        }

        

        



        
    }
}
