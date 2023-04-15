using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anselmo
{
    public class Uccellino
    {

        public int id { get; }
        public int number { get; }

        public Uccellino(int x, int n)
        {
            this.id = x;
            this.number = n;
        }
    }
}
