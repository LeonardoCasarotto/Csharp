using System;
using System.Windows.Forms;
using System.Collections.Generic;
//Using Anselmo.Classes


namespace Anselmo{

        public class MinHeap<Uccello>{

            // create a heap with an array

            Uccellino[] heap;
            int size;
            int cap;

            public MinHeap<Uccello> (int s){

                heap= new Uccellino[s];
                size=0;
                cap=s;


            }

            public Uccellino Parent(int pos){
                    
                    return heap[(i-1)/2];
    

            }
            public Uccellino LeftChild(int pos){
                    
                    return heap[(2*i)+1];
    

            }

            public Uccellino RightChild(int pos){
                    
                    return heap[(2*i)+2];
    

            }

            public Uccellino Min(int pos){

                return heap[0];
            }



            //inserire un elemento

            public void Insert(Uccellino t)
            {
                if(cap==size){
                    Double();
                }

                heap[size]=t;
                size++;
            }



            public void Heapify(int posizia)//ordina l'heap
            {
                int parent = Parent(posizia);
                 while (posizia > 0 && heap[posizia].number < heap[parent].number) {
                    Swap(pos, parent);
                    pos = parent;
                    parent = Parent(pos);
                }
            }

            //resize the heap
            public void Double(){

                cap = cap*2;
                Uccellino[] temp = new Uccellino[cap];
                for(int i=0; i<heap.Length; i++){
                    temp[i]=heap[i];
                }
                heap=temp;

            }

            //swap two elements
            public void Swap(int pos1, int pos2)
            {
                Uccellino temp = heap[pos1];
                heap[pos1] = heap[pos2];
                heap[pos2] = temp;
            }

            public int Height(){
                return (int)Math.Log(size,2);
            }

            public Uccellino RemoveMax(){
                int hei=Height();
                
                int x=2^(hei-1);
                arr[x] = arr[x+1];
                x++;
                Heapify();
            }




            
















        }
    

     public class Uccellino
    {

        public long id { get; }
        public int number { get; }

        public Uccellino(long identifier, int n)
        {
            this.id = identifier;
            this.number = n;
        }
    }











}