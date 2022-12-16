using System;
using System.Collections.Generic;
using System.Text;

namespace Es1215
{
    public class Atleta
    {
        string nome;
        string cognome;
        int età;
        bool personalizzazione;

        public Atleta(string n, string c, int e, bool p)
        {
            this.nome = n;
            this.cognome = c;
            this.età = e;
            this.personalizzazione = p;
        }
        public Atleta()
        {
        }

        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string name)
        {
            this.nome = name;
        }
        public string GetCognome()
        {
            return this.cognome;
        }
        public void SetCognome(string cg)
        {
            this.cognome = cg;
        }
        public bool GetPers()
        {
            return this.personalizzazione;
        }
        public string personalizza()
        {
            return this.nome + "\n" + this.cognome + "\n";
        }





        // classe publisher: squadra
        /*public event eventhandler PersonalizzaMaglia
         * dentro atleta va un metodo con firma event handler,se si desidera si aggancia il metodo 
        // classe che aderisce:*/
    }

    public class Squadra
    {
        string nome;
        Atleta[] giocatori;
        int index;
        

        public Squadra(string name, int part)
        {
            this.nome = name;
            giocatori = new Atleta[part];
            index = 0;
        }
        public void AddGiocatore(string n, string c, int e, bool p)
        {

            giocatori[index] = new Atleta(n, c, e, p);
            index++;
        }
        public Atleta GetGiocatore(int n)
        {

            return giocatori[n];
        }
        public int GetNpart()
        {
            return index;
        }
        public string PersonalizzaMaglia(int n)
        {
            return giocatori[n].personalizza() + n;
        }


    }





}

