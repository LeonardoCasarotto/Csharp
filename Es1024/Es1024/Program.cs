using static System.Console;
using System;

namespace Es1024
{
    class Program
    {
        public Garage rimessa;
        static void Main(string[] args)
        {
           Garage rimessa= new Garage();
            bool m = true;
            
            
            while (m)
            {
                Menu();
                switch (ReadLine())
                {
                    case "1":
                        New( rimessa);
                        break;

                    case "2":

                        break;
                    case "3":
                        WriteLine(rimessa.GetSituazione());
                        
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
                    int anno, cilindrata,doors=0,id;
                    string marca,alim="";
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
                   
                    rim.AddCar(anno, cilindrata, doors, marca, alim, id-1);
                    
                    WriteLine("Veicolo inserito correttamente!");

               break;
                    //furgone
               case "F":
                    int year, cil;
                    string mar;
                    float cap=0;
                    int p;

                    year = Anno();
                    mar = Marca();
                    cil = Cilindrata();

                    WriteLine("Inserire la capacità del furgone in Litri");
                    bool s = true;
                    while (s)
                    {
                        s = float.TryParse(ReadLine(), out cap);
                        if (!s || cap < 100 || cap > 50000)
                        {
                            Errore();
                        }
                        c = false;
                    }

                    p = Posteggio(rim);
                    
                    rim.AddFurgone(year, cil, mar, p-1, cap);
                    
                    WriteLine("Veicolo inserito correttamente!");


                    break;
                case "M":
                    int yr, cyl,j,st;
                    string br;
                    yr = Anno();
                    cyl = Cilindrata();
                    br = Marca();
                    WriteLine("Inserire il numero di tempi");
                    
                    bool d = true;
                    st = 0;
                    while (d)
                    {
                        d = Int32.TryParse(ReadLine(), out st);
                        if (!d || st< 1 || st > 10)
                        {
                            Errore();
                        }
                        
                    }
                    j = Posteggio(rim);
                    rim.AddMoto(yr, j-1, cyl, br, st);
                    WriteLine("Veicolo inserito correttamente!");


                    break;
                default:
                    Errore();
                    break;
            }
            return;
            

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
            WriteLine("Scegliere infine il numero del posteggio che si desidera occupare\n" + rim.GetSituazione());
            int parch=-1;
            bool c = true;
            while (c)
            {

                c = Int32.TryParse(ReadLine(), out parch);
                

                c = rim.parcheggia(parch);
                if (!c) Errore();
                else c = false;
            }
            return parch;
        }

        void Estrazione(Garage rim)
        {
            WriteLine("Inserire il numero del posteggio occupato");
            int choose;
            bool c = true;
            while (c)
            {
                c = Int32.TryParse(ReadLine(), out choose);

                if (!c || choose < 0 || choose > 15)
                {

                    Errore();
                    c = false;
                }
                rim.Esci(choose);
                WriteLine("Auto rimossa con successo!");
            }
        }
    }
}
