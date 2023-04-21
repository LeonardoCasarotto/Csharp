using System;
using System.Collections.Generic;
namespace TestHeap
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

        

        public int Altezza()//torev
        {
            return Convert.ToInt32(Math.Log2(occupied + 1));
        }

        public Uccellino RemoveRight()
        {
            Uccellino temp = heap[occupied];
            heap[occupied] = null;
            occupied--;
            return temp;

        }
        public void Inserisci(Uccellino uccellino)
        {
            if (occupied == capacity) { Resize(); }

            heap[occupied] = uccellino;
            occupied++;

            int currentIndex = occupied - 1;
            while (currentIndex > 0 && heap[currentIndex].number < Parent(currentIndex).number)
            {
                Uccellino temp = Parent(currentIndex);
                heap[(currentIndex - 1) / 2] = heap[currentIndex];
                heap[currentIndex] = temp;
                currentIndex = (currentIndex - 1) / 2;
            }
        }

        public void PrintHeapGraphically()
        {
            int currentLevel = 0;
            int currentLevelCount = 0;
            int currentLevelMax = 1;
            for (int i = 0; i < occupied; i++)
            {
                Console.Write(heap[i].number + " ");
                currentLevelCount++;
                if (currentLevelCount == currentLevelMax)
                {
                    Console.WriteLine();
                    currentLevel++;
                    currentLevelMax = (int)Math.Pow(2, currentLevel);
                    currentLevelCount = 0;
                }
            }
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

        public int[] Arr()
        {
            int[] temp = new int[occupied];

            for(int i = 0; i < occupied; i++)
            {
                temp[i] = heap[i].number;
            }
            return temp;
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
