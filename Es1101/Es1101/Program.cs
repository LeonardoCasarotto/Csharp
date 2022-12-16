using System;
using static System.Console;

namespace Es1101
{
    class Program
    {
        static void Main(string[] args)
        {
            Piazza[] array;
            int index = 0;
            WriteLine("Benvenuti, inserire la lunghezza dell'array!");
            bool c = false;
            int lg=0;
            while (!c)
            {

                c = Int32.TryParse(ReadLine(), out lg);
                if (!c || lg < 0)
                {
                    errore();
                    c = false;
                }
            }
            array = new Piazza[lg];

            while (true)
            {
                WriteLine("Scegliere cosa si vuole fare:" +
                    "\n 1.\t Inserire un nuovo oggetto piazza" +
                    "\n 2.\t Stampare tutto l'array" +
                    "\n 3.\t Festa" +
                    "\n 4.\t Esci");

                switch (ReadLine())
                {
                    case "1":
                        string nome="", città="";
                        double diametro=0;
                        WriteLine("Inserire il nome!");
                        c = false;
                        while (!c)
                        {
                            nome = ReadLine();
                            if (nome.Length < 2)
                            {
                                errore();
                            }
                            else c = true;
                        }
                        WriteLine("Inserire la città!");
                        c = false;
                        while (!c)
                        {
                            città = ReadLine();
                            if (città.Length < 2)
                            {
                                errore();
                            }
                            else c = true;
                        }
                        WriteLine("Inserire il diametro, in metri");
                        c = false;
                        while (!c)
                        {
                            c = Double.TryParse(ReadLine(),out diametro);
                            if (diametro < 10||!c)
                            {
                                errore();
                            }
                            
                        }

                        array[index] = new Piazza(nome, diametro, città);
                        index++;
                        WriteLine("Elemento inserito correttamente!");
                        break;
                    case "2":
                        for (int i = 0; i < index; i++)
                        {
                            WriteLine(i + 1 + ".\t" + array[i].Dettagli());
                        }
                        break;
                    case "3":
                        DateTime data= new DateTime();
                        int piazza=0;
                        WriteLine("Inserire il giorno della festa in formato gg/mm/aaaa");
                        c = false;
                        while (!c)
                        {
                            c = DateTime.TryParse(ReadLine(),out data);
                            if (!c)
                            {
                                errore();
                            }

                        }
                        WriteLine("inserire il numero indice della piazza");
                        c = false;
                        while (!c)
                        {
                            c = Int32.TryParse(ReadLine(), out piazza);
                            piazza--;
                            if (!c||piazza<0||piazza>index)
                            {
                                errore();
                            }

                        }
                        WriteLine(array[piazza].festa(data));
                        break;
                    case "4":
                        return;

                }
            }














        }
        static void errore()
        {
            WriteLine("Errore! Inserire i dati correttamente.");
        }
    }
}
