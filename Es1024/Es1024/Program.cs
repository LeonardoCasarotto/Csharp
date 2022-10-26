using static System.Console;
using System;

namespace Es1024
{
    class Program
    {
       
        static void Main(string[] args)
        {
           Garage rimessa= new Garage();
            bool m = true;
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

        static void New(Garage rim)
        {
            bool c;
            WriteLine("Inserire A per parcheggiare un'automobile, F per un furgone e M per una motocicletta");
            switch (ReadLine())
            {
                //automobile
                case "A":
                    int anno, cilindrata,doors,id;
                    string marca,alim;
                    anno = Anno();
                    marca = Marca();
                    cilindrata = Cilindrata();

                    bool z = true;
                    WriteLine("Inserire il numero di porte dell'auto");
                    while (z)
                    {
                        z = Int32.TryParse(ReadLine(), out doors);
                        if (!z || doors < 1|| doors > 7)
                        {
                            Errore();
                        }
                        z = false;
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

                    id = Posteggio(rim);
                    

                    break;
                    //furgone
               case "F":
                    int year, cil;
                    string mar;
                    float cap;

                    year = Anno();
                    mar = Marca();
                    cil = Cilindrata();

                    WriteLine("Inserire il numero di porte dell'auto");
                    while (c)
                    {
                        c = Int32.TryParse(ReadLine(), out doors);
                        if (!c || doors < 1 || doors > 7)
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
                                c = false;
                                break;
                            default:
                                Errore();
                                break;
                        }
                    }
                    WriteLine("Segliere infine il numero del posteggio che si desidera occupare\n" + rim.GetSituazione());
                    int parch;
                    while (c)
                    {

                        c = Int32.TryParse(ReadLine(), out parch);

                        c = rim.parcheggia(parch);
                        if (!c) Errore();
                    }

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
        
        static int Anno()
        {
            int anno = 0; 
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
            return anno;
        }
        // TODO: COMPLETE

        static string Marca()
        {
            bool c = true;
            string marca="";
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
            return marca;
        }
        static int Cilindrata()
        {
            bool c = true;
            int cilindrata = 0;
            WriteLine("Inserire la cilindrata del veicolo");

            while (c)
            {
                c = Int32.TryParse(ReadLine(), out cilindrata);
                if (!c || cilindrata < 10 || cilindrata > 5000)
                {
                    Errore();
                }
                else c = false;
            }
            return cilindrata;
        }
       static int Posteggio(Garage rim)
        {
            WriteLine("Segliere infine il numero del posteggio che si desidera occupare\n" + rim.GetSituazione());
            int parch=-1;
            bool c = true;
            while (c)
            {

                c = Int32.TryParse(ReadLine(), out parch);

                c = rim.parcheggia(parch);
                if (!c) Errore();
            }
            return parch;
        }
    }
}
