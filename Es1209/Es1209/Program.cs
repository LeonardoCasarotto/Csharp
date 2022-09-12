using System;
using System.Net.Http.Headers;
using static System.Console;

class Program
{
    static void Main()

    {
        bool firstime = true;
        
        int selezione =0;
        int[] punteggi = {};
        string[] matricole={};
        
        while (true)
        {
            WriteLine("Selezionare cosa si desidera svolgere:");
            WriteLine("-------");
            WriteLine("\t 1.Riempimento array");
            WriteLine("\t 2. Lettura array");
            WriteLine("\t 3. Calcolo media classe");
            WriteLine("\t 4. Uscita");
            WriteLine("-------");

            bool c = Int32.TryParse(ReadLine(), out selezione);
            while (!c|| selezione < 1 || selezione > 4)
            {
                WriteLine("inserire correttamente la selezione!");
                c = Int32.TryParse(ReadLine(), out selezione);
            }
            switch (selezione)
            {
                case 1:
                    matricole = riempistud();
                    punteggi = riempivoti(matricole);
                    firstime = false;
                    break;
                case 2:
                    if (firstime)
                    {
                        WriteLine("Attenzione! Occorre prima riempire gli array!");
                        WriteLine();
                        
                    }
                    else
                    {
                        stampa(matricole, punteggi);
                        
                    }
                    break;
                case 3:
                    if (firstime)
                    {
                        WriteLine("Attenzione! Occorre prima riempire gli array!");
                        WriteLine();

                    }
                    else
                    {
                        media(punteggi);
                    }
                    break;
                case 4:
                    return;
                    

                    


            }


        }
        


        

    }

    static string[] riempistud()
    {
        int n = 0;

        do
        {
            WriteLine("Inserire il numero degli studenti");
        } while (!Int32.TryParse(ReadLine(), out n) || n < 1);

        string[] matricole = new string[n];
          
        for(int i = 0; i < matricole.Length; i++)
        {
            WriteLine("Inserire il nome della matricola " + (i+1));
            matricole[i] = ReadLine();
            while(matricole[i] == " "|| matricole[i].Length == 0)
            {
                WriteLine("Inserire il nome correttamente!");
                matricole[i] = ReadLine();
            }

        }
        
        return matricole;

    }

    static int[] riempivoti(string[] matricole)
    {
        int[] punteggi = new int[matricole.Length];
        

        for( int i = 0; i < punteggi.Length; i++)
        {
           

            do
            {
                WriteLine("Inserire il punteggio di " + matricole[i]);
            } while (!Int32.TryParse(ReadLine(), out punteggi[i]) || punteggi[i] < 1 || punteggi[i]>100);

        }
        return punteggi;
    }
    static void stampa(string[] matricole, int[] voti)
    {
        for(int i = 0; i < matricole.Length; i++)
        {
            WriteLine((i+1)+".\t" + matricole[i] + "\t" + voti[i]);
        }
    }
    static void media(int[] punteggi)
    {
        float m = 0;
        for(int i = 0; i < punteggi.Length; i++)
        {
            m += punteggi[i];
        }
        WriteLine("La media uguale a "+m/punteggi.Length);
        WriteLine();
    }

}
