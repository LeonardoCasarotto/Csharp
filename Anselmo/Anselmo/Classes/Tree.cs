using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anselmo.Classes
{
    public class Tree
    {

        
        object _locker = new object();
        long _count = 0;


        public Tree()
        {
            

        }

        public void Togli()
        {
            lock (_locker)
            {
                
            }
        }


        public void Aggiungi()
        {
            lock (_locker)
            {
                
                
            }
        }

        
    }
}
