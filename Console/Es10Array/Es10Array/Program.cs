using System;
using static System.Console;

 class Program
{
    static void Main()
    {
        WriteLine("Benvenuti, inserire quanti operari si desidera gestire");
        int n=0;
        bool ver = false;
        do
        {
            ver=int.TryParse(ReadLine(), out n);
            if (!ver || n < 1)
            {
                ver = false;
                WriteLine("Inserisci i dati correttamente!");
            }
        } while (!ver);
        string[] nomi = new string[n];
        string[] cognomi = new string[n];
        double [] paghe = new double[n];
        for (int i = 0; i < n; i++)

        {
            //NOME
            WriteLine("Inserire il nome dell'operaio" + i + 1);
            ver = false;
            do
            {
                nomi[i] = ReadLine();
                if(nomi[i] != null || nomi[i] != "")
                {
                    ver = true;
                }
                else
                {
                    WriteLine("Ritenta!");
                }
            } while (!ver);
            //COGNOME
            WriteLine("Inserire il cognome dell'operaio" + i + 1);
            ver = false;
            do
            {
                cognomi[i] = ReadLine();
                if (cognomi[i] != null || cognomi[i] != "")
                {
                    ver = true;
                }
                else
                {
                    WriteLine("Ritenta!");
                }
            } while (!ver);
            //PAGA
            WriteLine("Inserire la paga dell'operaio" + i + 1);
            ver = false;
            do
            {
               ver=Double.TryParse(ReadLine(), out paghe[i]);
                if (!ver || paghe[i] < 5)
                {
                    WriteLine("Ritenta!");
                    ver = false;
                }
            } while (!ver);

        }

        Bubble(nomi, cognomi, paghe);



    }
    static void Leggi(string[] nome, string[] cognome, double [] paga)
    {
        for(int i = 0; i < nome.Length; i++)
        {
            Write(i+"\t "+nome[i]+" "+cognome[i]+" "+paga[i]);
        }
    }
    static void Bubble(string[] nome, string[] cognome, double[] paga)
    {
        string appnome, appcognome;
        double appaga;
        for(int i = 0; i < (paga.Length * (paga.Length - 1)) / 2; i++)
        {
            for(int j=0; j < (paga.Length - 1); j++)
            {

                if (paga[j + 1] < paga[j])
                {
                    //variabili d'appoggio
                    appaga= paga[j];
                    appnome= nome[j];
                    appcognome= cognome[j];

                    paga[j]=paga[j+1];
                    nome[j] = nome[j + 1];
                    cognome[j]=cognome[j+1];

                    paga[j + 1] = appaga;
                    nome[j + 1] = appnome;  
                    cognome[j + 1] = appcognome;


                }
            }
        }
        WriteLine("--------------");
        WriteLine("L'array ordinato:");
        for(int i = 0; i < nome.Length; i++)
        {
            WriteLine(i+"\t "+nome[i]+" "+cognome[i]+" "+paga[i]);
        }
    }
    
}