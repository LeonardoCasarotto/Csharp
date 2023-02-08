using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es0203
{
    class Barbiere
    {
        private Poltrona poltrona;
        private readonly object lockObject = new object();

        public Barbiere(Poltrona p)
        {
            this.poltrona = p;
        }
        
    }
}
