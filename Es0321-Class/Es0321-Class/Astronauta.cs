using System;
namespace Es0321_Class
{
    public enum stato { pronto,inAddestramento }
    public enum ruolo { scienziato, pilota, copilota, capitano, elettricista }
    public  abstract class Astronauta
    {
        public ruolo role { get; set; }
        public Astronauta()
        {

        }

        stato currentState;

        



        
    }
}
