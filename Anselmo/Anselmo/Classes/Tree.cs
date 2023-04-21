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

        MinHeap heap = new MinHeap(50);
        object _locker = new object();
        object _stampa = new object();
        bool edited = true;
        long _count = 0;


        public Tree()
        {
            

        }

        public void Remove()
        {
            lock (_locker)
            {
                



            }
        }


        public void Insert()
        {
            lock (_locker)
            {
                
                
            }
        }

        public int[] GetNdraw()
        {
            lock ( _locker)
            {


                return heap.getHeap();


            }

        }

        
    }
}
