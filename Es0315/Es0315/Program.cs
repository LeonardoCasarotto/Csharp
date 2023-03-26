 using System;
using System.Collections;
using System.Collections.Generic;

namespace Es0315
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class LinkedList<T> : IList<T>
        {
            public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            Node<T> head; // primo elemento della lista

            public int Count => throw new NotImplementedException();

            public bool IsReadOnly => throw new NotImplementedException();

            public void Add(T item)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(T item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public int IndexOf(T item)
            {
                throw new NotImplementedException();
            }

            public void Insert(int index, T item)
            {
                Node<T> curr = head;
                Node<T> prev = head;

                if (index < 0 || index > this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Node<T> newnode = new Node<T>(item);


                if (index == 0&&head==null)
                {
                    head = newnode;
                    if(head!=null)  newnode.next = head;

                    
                }
                else if (index == this.Count)
                {
                    for (int i = 0; i <this.Count-1; i++)
                    {
                        curr = curr.next;
                        curr.next = null;
                    }
                }




                throw new NotImplementedException();
            }

            public bool Remove(T item)
            {
                throw new NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        private class Node<T>
        {
            public T value;
            public Node<T> next;


            public Node(T value, Node<T> nextn = null)
            {
                this.value = value;
                this.next = nextn;
            }
        }
    }
}
