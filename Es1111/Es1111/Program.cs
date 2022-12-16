using System;
using static System.Console;
namespace Es1111
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Benvenuti! inserire la lunghezza dell'array!");

            bool m = false;
            int n = 0;
            while (!m)
            {
                m=Int32.TryParse(ReadLine(), out n);
                if (n < 1) m = false;

                if (!m) Errore();

            }

            Animale[] arr = new Animale[n];
            
            for(int i = 0; i < arr.Length; i++)
            {
                m = false;
               

                WriteLine("Inserire quale animale si desidera inserire:" +
                    "\n1.\t Armadillo" +
                    "\n2.\t Cane" +
                    "\n3.\t Gatto" +
                    "\n4.\t Giraffa");

                while (!m)
                {
                    switch (ReadLine())
                    {
                        case "1":
                            arr[i] = new Armadillo();
                            m = true;
                            break;

                        case "2":
                            arr[i] = new Cane();
                            m = true;
                            break;
                        case "3":
                            arr[i] = new Gatto();
                            m = true;
                            break;
                        case "4":
                            arr[i] = new Giraffa();
                            m = true;
                            break;
                        default:
                            Errore();
                            break;
                    }
                }
                arr[i].setNome(Nome());
                

            }















        }
        static string Nome()
        {
            WriteLine("Inserire il nome dell'animale!");
            bool g = false;
            string m = "";
            while (!g)
            {
                m = ReadLine();
                if (m.Length < 2)
                {
                    Errore();
                }
                else g = true;
            }
            return m;
        }
        static void Errore()
        {
            WriteLine("Attenzione! inserire i dati correttamente!");
        }
    }
}
