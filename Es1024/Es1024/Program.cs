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
                    int anno, cilindrata,doors;
                    string marca,alim;
                    WriteLine("Inserire l'anno di fabbricazione del veicolo:");
                    bool c = true;
                    while (c)
                    {
                        c = Int32.TryParse(ReadLine(), out anno);
                        if (!c || anno < 1950 || anno > DateTime.Now.Year)
                        {
                            Errore();
                        }
                        else c = false;
                    }
                    c = true;
                    WriteLine("Inserire la marca del veicolo");
                    while (c)
                    {
                        marca = ReadLine();
                        if (marca.Length < 1)
                        {
                            Errore();
                        }
                        else c = false;
                    }
                    c = true;
                    WriteLine("Inserire la cilindrata del veicolo");
                  
                    while (c)
                    {
                        c = Int32.TryParse(ReadLine(), out cilindrata);
                        if (!c || cilindrata < 10|| cilindrata>5000)
                        {
                            Errore();
                        }
                        else c = false;
                    }

                    WriteLine("Inserire il numero di porte dell'auto");
                    while (c)
                    {
                        c = Int32.TryParse(ReadLine(), out doors);
                        if (!c || doors < 1|| doors > 7)
                        {
                            Errore();
                        }
                        c = false;
                    }

                    WriteLine("infine selezionare 1 se l'automobile si alimenta a gasolio, 2 per la benzina e 3 elettrica");

                    c = true;
                    while (c)
                    {
                        switch (ReadLine())
                        {
                            case "1":
                                alim = "Gasolio";
                                c = false;
                                break;
                            case "2":
                                alim = "Benzina";
                                c = false;
                                break;
                            case "3":
                                alim = "elettrica";
                                c=false;
                                break;
                            default:
                                Errore();
                                break;
                        }
                    }
                    WriteLine("Segliere infine il numero del posteggio che si desidera occupare\n"//todo add arr garade)
                        );




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
