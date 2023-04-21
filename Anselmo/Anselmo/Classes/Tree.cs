using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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


        public void Insert(int num)
        {
            //lock (_locker)

                heap.Insert(new Uccellino(_count,num));
                _count++;

            //}
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
