using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anselmo.Classes
{
    public class MinHeap
    {
        private List<Uccellino> heap;

        public MinHeap()
        {
            heap = new List<Uccellino>();
        }

        public void Insert(Uccellino uccellino)
        {
            heap.Add(uccellino);
            int current = heap.Count - 1;
            while (current > 0 && heap[current].number < heap[(current - 1) / 2].number)
            {
                Uccellino temp = heap[current];
                heap[current] = heap[(current - 1) / 2];
                heap[(current - 1) / 2] = temp;
                current = (current - 1) / 2;
            }
        }

        public Uccellino ExtractMin()
        {
            if (heap.Count == 0)
            {
                throw new InvalidOperationException("L'heap è vuoto!");
            }
            Uccellino min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            int current = 0;
            while (true)
            {
                int left = current * 2 + 1;
                int right = current * 2 + 2;
                if (left >= heap.Count)
                {
                    break;
                }
                int smallest = left;
                if (right < heap.Count && heap[right].number < heap[left].number)
                {
                    smallest = right;
                }
                if (heap[current].number > heap[smallest].number)
                {
                    Uccellino temp = heap[current];
                    heap[current] = heap[smallest];
                    heap[smallest] = temp;
                    current = smallest;
                }
                else
                {
                    break;
                }
            }
            return min;
        }



    }
}
