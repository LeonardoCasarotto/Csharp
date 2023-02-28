using System;
using System.Collections.Generic;
using System.Text;

namespace Es0228.Classes
{
    public interface IPila<T>
    {
        void Push(T data);

        T Pop();
        T Top();
        void Clear();
        bool isEmpty();

    }

    class Pila<T> : IPila<T>
    {
        protected T[] aStack;
        protected int aTop;
        protected const int dim = 20;

        public Pila()
        {
            aStack = new T[dim];
            aTop = 0;
        }

        public void Clear()
        {
            aTop = 0;
        }

        public bool isEmpty()
        {
            return aTop == 0;
        }
        public T Pop()
        {
            T temp;
            temp = Top();
            aTop--;
            return temp;

        }
        public T Top()
        {
            if (!this.isEmpty())
            {
                return this.aStack[aTop - 1];
            }
            else
            {
                throw new EmptyStackException("Empty stack");
            }
        }
        public void Push(T data)
        {
            if (this.aTop == dim)
            {
                throw new FullStackException("Full Stack");
            }
            else this.aStack[aTop++] = data;
        }

    }
}
