using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Es1012
{
    public class Matrice
    {
        private int[,] matrix;
        private int rows;
        private int cols;
        public Matrice(int rows, int cols)
        {

            this.matrix = new int[rows, cols];
            this.rows = rows;
            this.cols = cols;
        }




        public int [,] SuMatrix(int[,] mat)
        {
            if (mat.Length != this.matrix.Length)
            {
                return this.matrix;
            }
            else
            {
                int[,] fin = new int[this.rows, this.cols];
                for (int i = 0; i < this.rows; i++)
                {
                    for(int m = 0; m < this.cols; m++)
                    {
                        fin[i, m] = mat[i, m] + this.matrix[i, m];
                    }
                }
                return fin;
            }

            
        }

        public int[,] DifMatrix(int[,] mat)
        {
            if (mat.Length != this.matrix.Length)
            {
                return this.matrix;
            }
            else
            {
                int[,] fin = new int[this.rows, this.cols];
                for (int i = 0; i < this.rows; i++)
                {
                    for (int m = 0; m < this.cols; m++)
                    {
                        fin[i, m] = this.matrix[i, m] - mat[i, m];
                    }
                }
                return fin;
            }

        }

        public int [,] TransMat()
        {
            for(int i = 0; i < this.rows; i++)
            {
                for(int m = i; m < this.cols; m++)
                {
                    int temp = this.matrix[i, m];
                    this.matrix[i, m] = this.matrix[m, i];
                    this.matrix[m, i] = temp;
                }
            }
            return this.matrix;
        }

        void print()
        {
            for(int i = 0; i < this.rows; i++)
            {
                for (int m = 0; m < this.cols; m++)
                {
                    Write(this.matrix[i, m]+"\t");
                }
                Write("\n");
            }
        }

        void printRow(int r)
        {
            for (int i = 0; i < this.cols; i++)
            {
                Write(this.matrix[r, i] + "\t");
            }
        }
        void printCol(int c)
        {
            for(int i = 0; i < this.rows; i++)
            {
                WriteLine(this.matrix[i, c]);
            }
        }

    }
}
