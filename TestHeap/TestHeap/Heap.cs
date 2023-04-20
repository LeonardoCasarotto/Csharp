using System;
using System.Collections.Generic;
namespace TestHeap
{

    public class MinHeap<Uccellino>
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

        public Uccellino  Parent(int index)
        {
            return heap[(index - 1) / 2];

        }

        public Uccellino LeftChild(int index) 
        {

            return heap[(2 * index) + 1];

        }

        public Uccellino RightChild(int index)
        {
            return heap[(2 * index) + 2];
        }

        public void Inserisci( Uccellino u)
        {
            heap[occupied] = u;
            int i = occupied;
            occupied++;

            while(i!= 0 && Parent(i).number > heap[i].number)
            {
                Uccellino temp = heap[i];
                heap[i] = Parent(i);
                heap[(i - 1) / 2] = temp;
                i = (i - 1) / 2;
            }
        }

        public int Altezza()//torev
        {
            return Convert.ToInt32(Math.Log2(occupied + 1));
        }



       

        public void Resize()
        {
            capacity = capacity * 2;
            Uccellino[] temp = new Uccellino[capacity];

            for(int i = 0; i < occupied; i++)
            {
                temp[i] = heap[i];
            }

            heap = temp;
        }








    }
    public class Uccellino
    {
        public int id { get; }
        public int number { get; }

        public Uccellino(int identifier, int num)
        {
            this.id = identifier;
            this.number = num;
        }
    }






}
