using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace WF_PrenotazioniDIM
{
    public enum DMI { TAC, RisonanzaMagnetica, RaggiX, Ecografia };
    
    public class Prenotazione
    {
        //campi privati visibili solo all'interno della classe Prenotazione
        private string nome;
        private string cognome;
        private DateTime dataprenot;

        private DMI tipoEsame;

        //PROPRIETà
        //proprietà pubbliche che danno accesso in lettura e/o scrittura controllata ai campi privati
        //costituiscono l'interfacccia offerta verso l'esterno
        public DMI Esame { get { return tipoEsame; } }


        public string Nome
        {
            get { return nome; }
            set { if (value.Length > 0) nome = value; }
        }


        public string Cognome { get; set; }  //prop+TAB  creo la proprietà automatica 
                                             //con la proprietà automatica non è necessario creare 
                                             //il campo privato esso viene generato dal compilatore

        public DateTime Dataprenot { get; set; }



        /*________ COSTRUTTORI_______________*/

        //costruttore di default o predefinito, senza parametri
        //ridefinisco il suo comportamento
        //NO PARAMETERS
        public Prenotazione()
        {
            Nome = "";  //riferisce una stringa vuota
            Cognome = "";
            tipoEsame = DMI.Ecografia;
            Dataprenot = DateTime.Now;
        }


        //costruttore standard: inizializzo tutti i campi con valori passati al costruttore
        //USING PARAMETERS
        public Prenotazione(string name, string surname, DMI tipo, DateTime d)
        {
            Nome = name;
            Cognome = surname;
            tipoEsame = tipo;
            Dataprenot = d;
        }


        /*____ METODI PUBBLICI  ________*/

        public string Stampa(int pos)
        {
            Console.WriteLine("\nprenotazione " + pos + ": " + Cognome + " " + Nome + " " + Dataprenot.ToLongDateString() + " " + tipoEsame);
            return "\nprenotazione " + pos + ": " + Cognome + " " + Nome + " " + Dataprenot.ToLongDateString() + " " + tipoEsame;
        }


    }



    public class Prenotazioni
    {
        private Prenotazione[] pvett;
        private int ultimo;  //ultimo elemento valorizzato del vettore
        private int indice;  //indice corrente dell'array



        public Prenotazioni() : this(100)
        {
            //array di 100 riferimenti ad oggetto
        }

        public Prenotazioni(int num)
        {
            ultimo = -1;
            indice = -1;
            if (num != 0)
                pvett = new Prenotazione[num];
            else
                pvett = new Prenotazione[100];
        }

        public bool Add(string nome, string cognome, DateTime d, DMI tipo)
        {
            bool ris = false;
            ultimo++;
            if (ultimo < pvett.Length)
            {
                pvett[ultimo] = new Prenotazione(nome, cognome, tipo, d);
                ris = true;
            }
            else ultimo = pvett.Length - 1;


            return ris;
        }


        //ritorna l'ultimo elemento del vettore
        public Prenotazione Last()
        {
            return pvett[ultimo];
        }

        //ritorna il prossimo elemento dell'array, si ferma se è stata raggiunta la fine degli elementi valorizzati 
        public Prenotazione Next()
        {
            if ((indice + 1) < ultimo)
            {
                indice++;
                return pvett[indice];
            }
            else
                return null;

        }
        // ritorna il primo elemento dell'array
        public Prenotazione First()
        {
            indice = 0;
            if (indice <= ultimo)
            {
                return pvett[indice];
            }
            else
                return null;

        }
        //TODO ricerca per cognome
        static class Program
        {
            /// <summary>
            /// Punto di ingresso principale dell'applicazione.
            /// </summary>
            /// MAIN METHOD
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }
    }
}
