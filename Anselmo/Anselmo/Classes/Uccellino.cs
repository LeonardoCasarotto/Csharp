using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anselmo.Classes;
namespace Anselmo
{
    public class Uccellino
    {

        public long id { get; }
        public int number;

        public Uccellino(long identifier, int n)
        {
            this.id = identifier;
            this.number = n;
        }

        public int Getnum()
        {
            return this.number;
        }
    }
}
