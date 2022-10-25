using static System.Console;

namespace Es1024
{
    class Program
    {
        static void Main(string[] args)
        {
            bool m = true;

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
                    //undone insert park verification.
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
        // TODO: ADD ERROR HANDLING 
        // TODO: COMPLETE


    }
}
