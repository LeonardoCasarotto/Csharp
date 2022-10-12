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
        private bool fill = false;
        public Matrice(int rows, int cols)
        {

            this.matrix = new int[rows, cols];
            this.rows = rows;
            this.cols = cols;
            
        }




        public int [,] SuMatrix(int [,] mat)
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
                WriteLine("Operazione svolta con successo!");
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

        public void print()
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
         public void Load()
        {
            for(int i = 0; i < this.rows; i++)
            {
                for(int m = 0; m < this.cols; m++)
                {
                    bool z = false;
                    while (!z) {
                        WriteLine("Inserire il numero a riga " + i + " e colonna " + m);
                        z = Int32.TryParse(ReadLine(), out this.matrix[i,m]);       
                     }
}
            }
            this.fill = true;
            WriteLine("La matrice è stata caricata correttamente!");
        }

        public void printRow(int r)
        {
            for (int i = 0; i < this.cols; i++)
            {
                Write(this.matrix[r, i] + "\t");
            }
        }
        public void printCol(int c)
        {
            for(int i = 0; i < this.rows; i++)
            {
                WriteLine(this.matrix[i, c]);
            }
        }

        public bool Loaded()
        {
            if (this.fill)
            {
                return true;
            }
            else return false;
        }

        public int [,] getma()
        {
            return this.matrix;
        }

        public int getrow()
        {
            return this.rows;
        }
        public int getcol()
        {
            return this.cols;
        }
    }
}
