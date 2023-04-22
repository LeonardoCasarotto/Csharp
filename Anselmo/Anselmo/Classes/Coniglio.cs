using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Anselmo.Classes
{
    public class Coniglio
    {
        Tree albero;


        public Coniglio(Tree t) 
        {
            this.albero = t;
        }

        public void Coniglia() 
        {
            albero.Insert(true);
        }


    }
}
