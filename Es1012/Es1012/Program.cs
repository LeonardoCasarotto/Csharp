using System;
using static System.Console;

namespace Es1012
{
    class Program
    {
        static void Main(string[] args)
        {
            bool m = false;
            int r=0;
            int c=0;
            
            while (!m){
                WriteLine("Benvenuti! inserire il numero di righe della prima matrice");
                m = Int32.TryParse(ReadLine(), out r);
                
            }
            m = false;
            while (!m)
            {
                WriteLine("Inserire ora il numero di colonne");
                m = Int32.TryParse(ReadLine(), out c);
            }
            Matrice mat1 = new Matrice(r, c);

            WriteLine("riempire la prima matrice:");
            mat1.Load();

            m = false;
            while (!m)
            {
                WriteLine("Inserire il numero di righe della seconda matrice");
                m = Int32.TryParse(ReadLine(), out r);

            }
            m = false;
            while (!m)
            {
                WriteLine("Inserire ora il numero di colonne");
                m = Int32.TryParse(ReadLine(), out c);
            }
            Matrice mat2 = new Matrice(r, c);
            WriteLine("riempire la seconda matrice");
            mat2.Load();



            while (true)
            {
                WriteLine("\n\nDigitare il numero dell'operazione che si desidera svolgere!");
                WriteLine("1. Modifica di matrice");
                WriteLine("2.somma di matrice");
                WriteLine("3.Differenza di matrici");
                WriteLine("4.Transposizione di matrice");
                WriteLine("5.Stampa di matrice");
                WriteLine("6.Stampa riga");
                WriteLine("7. Stampa colonna");

                switch (ReadLine())
                {
                    case "1":
                        WriteLine("Inserire 1 per la prima matrice o 2 per la seconda");
                        switch (ReadLine())
                        {
                            case "1":
                                mat1.Load();
                                break;
                            case "2":
                                mat2.Load();
                                break;
                            default:
                                errore();
                                break;
                        }
                        break;

                    case "2":
                        mat1.SuMatrix(mat2.getma());

                        break;
                    case "3":
                        mat1.DifMatrix(mat2.getma());
                        break;
                    case "4":
                        WriteLine("Inserire 1 per la prima matrice o 2 per la seconda");
                        switch (ReadLine())
                        {
                            case "1":
                                mat1.TransMat();
                                break;
                            case "2":
                                mat2.TransMat();
                                break;
                            default:
                                errore();
                                break;
                        }

                        break;
                    case "5":
                        WriteLine("Inserire 1 per la prima matrice o 2 per la seconda");
                        switch (ReadLine())
                        {
                            case "1":
                                mat1.print();
                                break;
                            case "2":
                                mat2.print();
                                break;
                            default:
                                errore();
                                break;
                        }
                        break;
                    case "6":
                        WriteLine("Inserire 1 per la prima matrice o 2 per la seconda");
                        switch (ReadLine())
                        {
                            case "1":
                                
                                
                                m = false;
                                int z = 0;
                                while (!m||z>mat1.getrow())
                                {
                                    WriteLine("Inserire il numero della riga");
                                    m = Int32.TryParse(ReadLine(), out z);
                                }
                                mat1.printRow(z);
                                break;
                            case "2":
                                m = false;
                                int x = 0;
                                while (!m || x > mat2.getrow())
                                {
                                    WriteLine("Inserire il numero della riga");
                                    m = Int32.TryParse(ReadLine(), out x);
                                }
                                mat2.printRow(x);

                                break;
                            default:
                                errore();
                                break;
                        }
                        break;
                    case "7":
                        WriteLine("Inserire 1 per la prima matrice o 2 per la seconda");
                        switch (ReadLine())
                        {
                            case "1":


                                m = false;
                                int z = 0;
                                while (!m || z > mat1.getcol())
                                {
                                    WriteLine("Inserire il numero della colonna");
                                    m = Int32.TryParse(ReadLine(), out z);
                                }
                                mat1.printCol(z);
                                break;
                            case "2":
                                m = false;
                                int x = 0;
                                while (!m || x > mat2.getcol())
                                {
                                    WriteLine("Inserire il numero della colonna");
                                    m = Int32.TryParse(ReadLine(), out x);
                                }
                                mat2.printCol(x);

                                break;
                            default:
                                errore();
                                break;
                        }

                        break;
                    default:
                        errore();
                        break;
                }
            }

        }

        static void errore()
        {
            WriteLine("Inserire i dati correttamente!");
        }

       
    }
}
