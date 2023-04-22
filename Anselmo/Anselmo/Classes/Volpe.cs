using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Anselmo.Classes
{
    public class Volpe
    {
        Tree albero;

        public Volpe(Tree al) 
        {

            this.albero = al;
        }

        public void Volpeggia()
        {
            albero.Remove(true);
        }

    }
}
