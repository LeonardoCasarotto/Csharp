using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es0306
{
    public class Regina
    {
        int id { get; }
        int posiziax { get; set; }
        int posiziay { get; set; }
        
        public Regina(int identifier,int x,int y )
        {
            this.id = identifier;
            this.posiziax = x;
            this.posiziay = y;
        }


    }
}
