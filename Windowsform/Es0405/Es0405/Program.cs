using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
namespace WF_PrenotazioniDIM {
    public enum DMI { TAC, RisonanzaMagnetica, RaggiX,Ecografia};
    public class Prenotazione
    {
        private string nome;
        private string cognome;
        private DateTime dataprenot;
        private DMI tipoEsame;
        public DMI Esame { get { return tipoEsame; } }
        public string Nome
        {
            get { return nome; }
            set { if (value.Length > 0) nome = value; }
        }
        public string Cognome {
            get; set;
        }
        public DateTime DataPrenot
        { get; set; }
        public Prenotazione() {
            Nome = "";
            Cognome = "";
            tipoEsame = DMI.Ecografia;
            DataPrenot = DateTime.Now;
        }
        public Prenotazione(string name, string surname, DMI tipo, DateTime d){
            Nome = name;
            Cognome = surname;
            tipoEsame = tipo;
            dataprenot = d;

        }
        //PUBBLICI
        public string Stampa(int pos)
        {
            Console.WriteLine("\nprenotazione " + pos + ":" + Cognome + " " + Nome + " " + tipoEsame + " " + DataPrenot.ToLongDateString);
            return "prenotazione " + pos + ":" + Cognome + " " + Nome + " " + tipoEsame + " " + DataPrenot.ToLongDateString;
        }
        public class Prenotazioni
    {
        private Prenotazione[] pvett;
        private int ultimo;
        private int indice;

        public Prenotazioni()
        {
            //array di 100 riferimenti

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
        } }