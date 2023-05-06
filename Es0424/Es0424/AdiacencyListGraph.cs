using System;
using System.Collections.Generic;
using System.Text;

namespace Es0424
{
    class AdiacencyListGraph
    {
        public int noVertices { get; }
        private LinkedList<int>[] arrLinkedList;
        //array di linked list,
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


        public string PrintAdjencyList()
        {
            string topr = "";
            for (int i = 0; i < arrLinkedList.Length; i++)
            {
                topr += " [Node val: " + i + "with neighbors ";
                foreach (var n in arrLinkedList[i])
                {
                    topr += " --> " + n;
                }
                topr += "]";
            }

            return topr;
        }

        public void CreateAdjencyMatrix(AdiacencyListGraph g)
        {
            int?[,] adjanceyMatrix = new int?[g.noVertices, g.noVertices];


            for (int parentVertex = 0; parentVertex < g.noVertices; parentVertex++)
            {
                var parentNode = arrLinkedList[parentVertex];


                for (int childNode = 0; childNode < g.noVertices; childNode++)
                {
                    if (parentVertex != childNode)
                    {
                        var arc = parentNode.Find(childNode);


                        if (arc != null)
                        {
                            adjanceyMatrix[parentVertex, childNode] = 1;
                        }



                    }
                }

            }
            //PrintAdjanceyMatrix(adjanceyMatrix, graph.totalVertices);
        }

        public string PrintAdjecyMatrix(int?[,] adj, int Length)
        {

        }

    }
}