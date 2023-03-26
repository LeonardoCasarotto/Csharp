using System;
using System.Threading;

namespace Es0321_Form
{
    public class AstronautainMiss:Astronauta
    {

        public Missione incorso { get; }
        public AstronautainMiss(ruolo rl,Missione mi):base(stato.pronto,rl)
        {
            this.incorso = mi;
        }

        public void vola()
        {
            Thread.Sleep(2000);
            
        }
    }
}
