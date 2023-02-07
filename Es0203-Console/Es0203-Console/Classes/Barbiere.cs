using System;
using System.Collections.Generic;
using System.Text;

namespace Es0203_Console.Classes
{
    public class Barbiere
    {
        public Negozio n;

        public  Barbiere(Negozio ne)
        {
            this.n = ne;
        }
        
        public void Addormentato()
        {
            for(int i = 0; i < Program.qu.Count;i++)
            {
                n.Sleep();
            }
        }
        




    }
}
