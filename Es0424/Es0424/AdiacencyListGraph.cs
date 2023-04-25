using System;
using System.Collections.Generic;
using System.Text;

namespace Es0424
{
    class AdiacencyListGraph
    {
        private int noVertices;
        private LinkedList<int>[] arrLinkedList; //array di linked list,
        //come da definizione, ogni nodo possiede una lista di nodi al quale può essere
        //collegato

        public AdiacencyListGraph(int n)
        {
            noVertices = n;
            arrLinkedList = new LinkedList<int>[n];


            //initialization of the lists
            for (int i = 0; i < noVertices; i++)
            {
                arrLinkedList[i] = new LinkedList<int>();
            }
        }

        public void addEdge(int v, int ad)
        {
            arrLinkedList[v].AddLast(ad);
            //
        }



    }
}
