using System;
using static System.Console;

namespace Revise
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 5, 9, 4, 8, 3, 1, 0, 55, 12 };
            QuickSort(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                WriteLine(array[i]);
            }




        }

        //selection sort

        static int[] selection(int[] array, int i, int j)
        {
            if (i < array.Length - 1)
            {
                if (j < array.Length)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    return selection(array, i, j + 1);
                }
                else
                {
                    return selection(array, i + 1, i + 1);
                }
            }
            else
            {
                return array;
            }


        }

        //bubble sort

        static int[] bubble(int[] array, int right)
        {

            if (right == 0)//caso base
            {
                return array;
            }
            for (int i = 0; i < right; i++)
            {
                if (array[i + 1] < array[i])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;

                }

            }
            right--;
            return bubble(array, right);
        }

        //mergesort


        static void MergeSort(int[] vett, int left, int right)
        {
            if (left < right)
            {
                int center = (left + right) / 2;



                MergeSort(vett, left, center);

                MergeSort(vett, center + 1, right);

                Merge(vett, left, center, right);

            }




        }



        static void Merge(int[] vett, int left, int center, int right)
        {
            int i = left, j = center + 1, k = 0;
            int[] temp = new int[right - left + 1];

            //prendo il più piccolo dell'arr di sinistra o di destra
            while (i <= center && j <= right)
            {
                if (vett[i] < vett[j])
                    temp[k++] = vett[i++];
                else
                    temp[k++] = vett[j++];

            }

            //copio ciò che rimane  
            while (i <= center)
                temp[k++] = vett[i++];

            while (j <= right)
                temp[k++] = vett[j++];



            //copio l'array fuso in vett
            i = left;
            for (k = 0; k < temp.Length; k++)
                vett[i++] = temp[k];

        }

        //quicksort
        static public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            { //l’array deve essere formato da più di un elemento

                //altrimenti termino

                int splitpoint = Partition(arr, left, right);
                QuickSort(arr, left, splitpoint - 1);
                QuickSort(arr, splitpoint + 1, right);
            }
        }
        static public int Partition(int[] arr, int left, int right)
        {
            int pivotvalue = arr[left];
            int leftmark = left + 1;
            int rightmark = right;
            bool done = false;
            while (!done)
            {
                while (leftmark <= right && arr[leftmark] <= pivotvalue) // se è falsa la prima condizione non viene valutata la seconda

                    leftmark++; // per la quale andrebbe in overflow l'indice dell'array

                while (rightmark > left && arr[rightmark] >= pivotvalue)
                    rightmark--;
                if (rightmark < leftmark)
                    done = true;
                else
                {
                    int tmp = arr[leftmark];
                    arr[leftmark] = arr[rightmark];
                    arr[rightmark] = tmp;

                }
            }
            int temp = arr[left]; // pivotvalue
            arr[left] = arr[rightmark];
            arr[rightmark] = temp;
            return rightmark; //posizione del pivot o split position}









        }

    }
}
