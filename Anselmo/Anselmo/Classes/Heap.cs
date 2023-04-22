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
            if(occupied == 0) return null;
            int[] temp = new int[occupied];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = heap[i].number;
            }

            return temp;
        }
        public void Insert(Uccellino x)
        {
            if (occupied == capacity)
            {
                Resize();
            }

            heap[occupied] = x;

            int current = occupied;
            int parent = (current - 1) / 2;

            while (parent >= 0 && heap[current].number < heap[parent].number)
            {
                Swap(heap, current, parent);

                current = parent;
                parent = (current - 1) / 2;
            }

            occupied++;
        }



        private void Swap(Uccellino[] arr, int i, int j)
        {
            Uccellino temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }





    }


}
