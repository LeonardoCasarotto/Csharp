using System;
using System.Collections.Generic;
using System.Text;

namespace Es1101
{
    public class Piazza:Fontana
    {
        private double diametro;
        private string città;

        public Piazza(string nome, double diam, string city): base(nome)
        {
            this.diametro = diam;
            this.città = city;
        }
        public string Dettagli()
        {
            return nome + "\t" + città + "\t" + diametro + "m";
        }
        public string  festa(DateTime giorno)
        {
            return "la festa si svolgerà il " + giorno.ToString("dd/MM/yyyy") + " nella piazza " + nome + " di diametro " + diametro + "m presso " + città;
        }
    }
}
