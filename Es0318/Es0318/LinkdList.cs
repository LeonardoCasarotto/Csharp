using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Es0318
{
    public class LinkedList<T> : IList<T>
    {
        Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        public LinkedList(T value)
        {
            Node<T> n = new Node<T>(value);
            head = n;
        }


        private class Node<T1>
        {
            public T1 Value { get; set; }
            public Node<T1> Next { get; set; }

            public Node(T1 value, Node<T1> nextN = null)
            {
                this.Value = value;
                this.Next = nextN;
            }
        }


        public T this[int index] { get => GetItem(index); set => SetItem(value, index); }

        public int Count=>Size();

        public int Length = 0;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            Insert(Length, item);
        }


        private int Size()
        {
            int ris = 0;
            Node<T> cur = head;
            if (cur != null)
            {
                while (cur.Next != null)
                {
                    cur = cur.Next;
                    ris++;
                }
                ris++; // increment ris one more time for the last node
            }
            return ris;
        }


        private T GetItem(int index)
        {

            Node<T> curr = head;

            if (index < 0 || index >= Length)
            {
                throw new ArgumentOutOfRangeException();
            }


            for (int i = 0; i < index; i++)
            {
                curr = curr.Next;
            }

            return curr.Value;

        }


        private void SetItem(T value, int index)
        {
            Node<T> curr = head;

            if (index < 0 || index >= Length)
            {
                throw new ArgumentOutOfRangeException();
            }


            for (int i = 0; i < index; i++)
            {
                curr = curr.Next;
            }

            curr.Value = value;

        }

        public void Clear()
        {
            while (Length > 0)
            {
                RemoveAt(0);
            }

        }

        public bool Contains(T item)
        {
            Node<T> curr = head;

            bool ris = false;

            int i = 0;
            while (i < Count && !curr.Value.Equals(item))
            {
                curr = curr.Next;
                i++;
            }



                if (curr!= null && curr.Value.Equals(item))
                {
                    ris = true;
                }
            
            return ris;


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


            if (index < 0 || index > this.Length)
            {
                throw new ArgumentOutOfRangeException("Errore sull'indice");
            }

            Node<T> newnode = new Node<T>(item);

            if (index == 0)
            {
                if (head != null)
                {
                    newnode.Next = head;

                }
                head = newnode;
                Length++;
                
            }
            else if (index == Length)
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    curr = curr.Next;
                }
                curr.Next = newnode;
                Length++;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    curr = curr.Next;
                }
                newnode.Next = curr.Next;
                curr.Next = newnode;
                Length++;
            }
            
        }

        public bool Remove(T item)
        {
            Node<T> curr = head;
            Node<T> prev = head;
            int i = 0;
            while (i < Length && !curr.Value.Equals(item))
            {
                prev = curr;
                curr = curr.Next;
                i++;
            }


            if (!curr.Value.Equals(item))
            {
                return false;
            }
            else
            {
                if (i == 0)
                {
                    head = curr.Next;

                }
                else
                {
                    prev.Next = curr.Next;
                }
                Length--;

                curr.Next = null;

                return true;

            }
        }

        public void RemoveAt(int index)
        {
            Node<T> curr = head;
            Node<T> prev = head;

            if (index < 0 || index >= this.Length)
                throw new ArgumentOutOfRangeException();

            if (Length == 1 && index == 0)
            {
                head = null;
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    prev = curr;
                    curr = curr.Next;

                }

                //prev riferisce il nodo index-1
                //curr riferisce il nodo index

                prev.Next = curr.Next;
                curr.Next = null;
                Length--;
            }


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

