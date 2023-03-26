using System;
using System.Collections.Generic;

namespace Es0321_Class
{
    public enum stato { pronto,inAddestramento }
    public enum ruolo { scienziato, pilota, copilota, capitano, elettricista }
    public  abstract class Astronauta
    {
        public ruolo role { get;}
        public LinkedList<int> missions; // memorize missions ids
        public stato currentState { get;}

        public Astronauta(stato cr,ruolo rl)
        {

            missions = new LinkedList<int>();
            this.role = rl;
            this.currentState = cr;
            

        }

        

        



        
    }
}
