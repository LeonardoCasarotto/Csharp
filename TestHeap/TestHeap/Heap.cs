using System;
using System.Collections.Generic;
namespace TestHeap
{

    public class MinHeap<Uccellino>
    {
        Uccellino[] heap;
        int size;
        int cap;

        public MinHeap(int s)
        {
            heap = new Uccellino[s];
            size = 0;
            cap = s;
        }

        public Uccellino Parent(int pos)
        {

            return heap[(pos - 1) / 2];


        }
        public Uccellino LeftChild(int pos)
        {

            return heap[(2 * pos) + 1];


        }

        public Uccellino RightChild(int pos)
        {

            return heap[(2 * pos) + 2];


        }

        public Uccellino Min()
        {

            return heap[0];
        }

        public void Insert(Uccellino t)
        {
            if (cap == size)
            {
                Double();
            }

            heap[size] = t;
            size++;
        }

        public void Double()
        {

            cap = cap * 2;
            Uccellino[] temp = new Uccellino[cap];
            for (int i = 0; i < heap.Length; i++)
            {
                temp[i] = heap[i];
            }
            heap = temp;

        }
        public void Heapify(int posizia)//ordina l'heap
        {
            int parent = heap[posizia].GetNumber();
        }
















    }
    





}
