using System;
using System.Threading;
namespace Es0321_Class
{
    public class AstronautaInAdd:Astronauta
    {
        public int hoursTechnique;
        public int hoursPhisique;


        public AstronautaInAdd(ruolo rl, int ht, int hp): base(stato.inAddestramento,rl)
        {
            this.hoursTechnique = ht;
            this.hoursPhisique = hp;
        }

        public bool Addestra()
        {
            if (this.hoursTechnique < 1 && this.hoursPhisique < 1)
            { 
                return false;
            }
            else
            {
                Thread.Sleep((hoursPhisique + hoursTechnique) * 100);
                hoursPhisique = 0;
                hoursTechnique = 0;
                return true;
            }
        }
    }
}
