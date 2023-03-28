using System;
namespace Es0328_Class
{
    public class CQueue<T> : IQueue<T>
    {

        Node<T> First;
        Node<T> Last;

        public int Count { get => Size(); }

        public CQueue()
        {
            First = Last = null;
        }
        public CQueue(T item)
        {
            First = new Node<T>(item);
            Last = null;

        }


        private int Size()
        {
            Node<T> curr = First;
            int count = 0;
            if (curr == null) return count;
            while (curr != null)
            {
                curr = curr.Next;
                count++;
            }

            return count;
        }

        public void Clear()
        {

            Node<T> curr = First;
            while (curr != null)
            {

                curr = curr.Next;

            }

        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new ArgumentNullException();
            }
            T val = First.Value;
            First = First.Next;
            return val;
        }

        public void Enqueue(T item)
        {
            Node<T> newnode = new Node<T>(item, First);
            First = newnode;

        }

        public T Front()
        {
            if (IsEmpty())
            {
                throw new ArgumentNullException();
            }

            return First.Value;
        }

        public bool IsEmpty()
        {
            if (Count == 0) return true;
            else return false;
        }
    }
    interface IQueue<T>
    {
        //todo add get and set
        public void Enqueue(T item);
        public T Dequeue();
        public bool IsEmpty();
        public T Front();
        public void Clear();


    }
    class Node<T>
    {
        public T Value;
        public Node<T> Next;
        private T item;

        public Node(T item)
        {
            this.item = item;
        }

        public Node(T val, Node<T> ne)
        {
            this.Value = val;
            this.Next = ne;

        }
    }
}
