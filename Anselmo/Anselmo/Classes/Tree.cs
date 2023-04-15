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

        MinHeap albero = new MinHeap();
        object _locker = new object();


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
