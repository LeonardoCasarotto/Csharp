using static System.Console;
using System;

namespace Es1024
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool m = true;
            WriteLine(DateTime.Now.Year.ToString());
            
            while (m)
            {
                Menu();
                switch (ReadLine())
                {
                    case "1":

                        break;

                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Errore();
                        break;
                }

            }
        }

        static void Menu()
        {
            WriteLine("Segliere cosa si desidera fare:" +
                "\n1.Inserimento Veicolo" +
                "\n2.Estrazione veicolo" +
                "\n3.Stampa situazione corrente");
        }

        static void New()
        {
            WriteLine("Inserire A per parcheggiare un'automobile, F per un furgone e M per una motocicletta");
            switch (ReadLine())
            {
                case "A":
                    int anno, cilindrata;
                    string marca;
                    WriteLine("Inserire l'anno di fabbricazione del veicolo:");
                    bool c = true;
                    while (c)
                    {
                        c = Int32.TryParse(ReadLine(), out anno);
                        if (!c || anno < 1950 || anno < DateTime.Now.Year)
                        {
                            Errore();
                        }
                        c = false;
                    }
                    c = false;
                    

                    break;
               case "F":
                    break;
                case "M":
                    break;
                default:
                    Errore();
                    break;
            }
        }
        static void Errore()
        {
            WriteLine("Errore! Ritentare.");
        }
        
        // TODO: COMPLETE


    }
}
