﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Es0302
{
    public interface Istack<T>
    {
        void Push(T dato);
        T Pop();
        T Top();
        void Clear();

        bool isEmpty();

    }

    class Pila<T> : Istack<T>
    {
        protected T[] aStack;
        protected int aTop;
        protected const int DIM = 10;

        public Pila()
        {
            aStack = new T[DIM];
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

        public void Push(T dato)
        {
            if (aTop == DIM)
            {
                throw new FullStackException("Full stack");
            }
            else aStack[aTop++] = dato;
        }

        public T Top()
        {
            if (!this.isEmpty())
            {
                return this.aStack[aTop - 1];
            }
            else
            {
                throw new EmptyStackException("Stack Empty");

            }
        }


    }


}