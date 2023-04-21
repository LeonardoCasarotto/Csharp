using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Anselmo.Classes
{
    public class MinHeap
    {
        Uccellino[] heap;
        int capacity;
        int occupied;


        public MinHeap(int size)
        {
            this.heap = new Uccellino[size];
            this.capacity = size;
            this.occupied = 0;
        }

        public Uccellino Parent(int index)
        {
            if (index % 2 == 0)
            {
                return heap[index / 2];
            }
            else
            {
                return heap[(index - 1) / 2];
            }
            

        }

        public Uccellino LeftChild(int index)
        {

            return heap[(2 * index) + 1];

        }

        public Uccellino RightChild(int index)
        {
            return heap[(2 * index) + 2];
        }

        public void Insert(Uccellino u)
        {
            if (occupied == capacity) Resize();



            heap[occupied] = u;
            int i = occupied;
            occupied++;

            while (i != 0 && ((Uccellino)Parent(i)).number > ((Uccellino)heap[i]).number)
            {
                Uccellino temp = heap[i];
                heap[i] = Parent(i);
                heap[(i - 1) / 2] = temp;
                i = (i - 1) / 2;
            }
        }

        

        public Uccellino removeRight()
        {
            Uccellino temp = heap[occupied];
            heap[occupied] = null;
            occupied--;
            return temp;

        }

        


        public void Resize()
        {
            capacity = capacity * 2;
            Uccellino[] temp = new Uccellino[capacity];

            for (int i = 0; i < occupied; i++)
            {
                temp[i] = heap[i];
            }

            heap = temp;
        }

        public int[] getHeap()
        {
            int[] temp = new int[occupied];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = heap[i].number;
            }

            return temp;
        }

    }

}
