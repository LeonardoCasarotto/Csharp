using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anselmo.Classes
{
    public class MinHeap<T> where T : Uccellino
    {
        private List<T> arr;
        private int posizione;

        public MinHeap()
        {
            this.arr = new List<T>();
            this.posizione = 0;
            Console.WriteLine("Nuovo heapmin creato");
        }

        public T MinValue()
        {
            if (posizione > 0)
                return arr[0];
            else
                return null;
        }

        public int SizeOfHeap()
        {
            return posizione;
        }

        public void Add(T value)
        {
            arr.Add(value);
            posizione++;
            Ordinamento(posizione - 1);
            Console.WriteLine("Uccello appena arrivato!");
        }

        private void Scambia(int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void Ordinamento(int index)
        {
            if (index <= 0)
            {
                return;
            }

            int parent = (index - 1) / 2;
            if (arr[index].number < arr[parent].number)
            {
                Scambia(index, parent);
                Ordinamento(parent);
            }
        }

        public void Stampa()
        {
            Console.WriteLine("Stampo array:");
            foreach (T uccellino in arr)
            {
                Console.WriteLine(uccellino.id + ", " + uccellino.number);
            }
            Console.WriteLine();
        }

        public int Altezza()
        {
            return (int)Math.Ceiling(Math.Log(posizione + 1, 2)) - 1;
        }

        public void Estrai()
        {
            if (posizione <= 0)
            {
                return;
            }

            arr[0] = arr[posizione - 1];
            arr.RemoveAt(posizione - 1);
            posizione--;

            if (posizione > 1)
            {
                Heapify(0);
            }
        }

        private void Heapify(int index)
        {
            int smallest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            if (left < posizione && arr[left].number < arr[smallest].number)
            {
                smallest = left;
            }

            if (right < posizione && arr[right].number < arr[smallest].number)
            {
                smallest = right;
            }

            if (smallest != index)
            {
                Scambia(index, smallest);
                Heapify(smallest);
            }
        }
    }

}
