using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ANSEL{
    internal class HeapMin<Uccello>
    {
        Uccello[] arr;
        private int posizione { get; set; }

        //costruttore
        public HeapMin(int size)
        {  
            this.arr= new Uccello[size];
            this.posizione = 1;
            Console.WriteLine("Nuovo heapmin creato");
        }

        //ritorna il valore minimo, cioè quello piu in alto
        public Uccello MinValue()
        {
            if (posizione != 1)
                return arr[1];
            else
                return arr[0];
        }

        //ritorna il numero di elementi presenti nell'heap
        public int SizeOfHeap(){    
            return posizione-1;  //posizione dell'ultimo elemento
        }

        //controllo dell'heap
        public void Add(Uccello value){
            if(posizione<=arr.Length-1){
                Aggiungi(value);
            }
            else{
                arr=Resize();
                Aggiungi(value);
            }
        }

        //ridimensiona l'array di appoggio
        private Uccello[] Resize(){
            Uccello[] temp = new Uccello[arr.Length*2];
            for(int i=0; i<arr.Length; i++){
                temp[i]=arr[i];
            }
            Console.WriteLine("Ridimensionamento dell'array avvenuto");
            return temp;
        }

        //inserisce un elemento nell'heap
        private void Aggiungi(Uccello value){   
            arr[posizione] = value;  
            posizione++;  
            Ordinamento(posizione);   
            MessageBox.Show("Uccello appena arrivato!");  
        } 

        //trova il parent di un elemento
        private int Parent(int pos){
            if(pos%2==0){
                return pos/2;
            }
            else{
                return (pos-1)/2;
            }
        }

        //mette l'elemento nella posizione corretta
        private void Ordinamento(int index) { //num1 è il numero dell'index mentre num 2 è il valore di index+1 
            if (index <= 1) {  
                return;  
                Console.WriteLine("Siamo gia nella radice");
            }
            int parent = Parent(index);    
            if (arr[index].GetDimensioni() < arr[parent].GetDimensioni()) {  
                Uccello tmp = arr[index];  
                arr[index] = arr[parent];  
                arr[parent] = tmp;  
            }  
            Ordinamento(parent);  
        }
        
        //stampa l'heap
        public void stampa() {  
            Console.WriteLine("Stampo array");// Printing from 1 because 0th cell is dummy  
            for (int i = 1; i <= posizione-1; i++) {  
                Console.WriteLine(arr[i] + " ");  
            }  
            Console.WriteLine("\n");  

        }

        //altezza dell'albero
        public int altezza() {  
            return (int) Math.Ceiling(Math.Log(posizione) / Math.Log(2));  
        }

        private int num;
        
        //estrae l'ultima foglia a sinistra dell'heap
        public void estrai(){
            if(posizione<2){
                return;
            }
            else{
                int h=altezza();
                num=2^(h-1);
                arr[num] = arr[num+1];
                num = num + 1;
                Ordina();
            }
        }
        
        //mette in ordina l'heap
        public void Ordina(){
            for(int i=num; num<posizione-1; num++){

                arr[num]=arr[num+1];

                Ordinamento(num);
            }
        }

        

        //elimina il valore piú basso a destra


    }
}