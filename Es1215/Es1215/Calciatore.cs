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
        bool personlizzazione;

        public Atleta(string n, string c, int e,bool p)
        {
            this.nome = n;
            this.cognome = c;
            this.età = e;
            this.personlizzazione = p;
        }
        // classe publisher: squadra
        /*public event eventhandler PersonalizzaMaglia
         * dentro atleta va un metodo con firma event handler,se si desidera si aggancia il metodo 
        // classe che aderisce:*/
    }

}
