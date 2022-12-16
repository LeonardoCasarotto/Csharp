using System;
using System.Collections.Generic;
using System.Text;

namespace Es1101
{
    public class Fontana
    {
        protected string nome;
        private bool on;
        private string[] manutenzioni;
        private float portata;
        private string autore;
        private int indexman=0;



        public Fontana(string name)
        {
            this.nome = name;
        }
        public Fontana(string name,bool accesa,int manitenance, float cap,string artist)
        {
            this.nome = name;
            this.on = accesa;
            this.manutenzioni = new string[manitenance];
            this.portata = cap;
            this.autore = artist;

        }

        public void AddManutenzione(string m)
        {
            manutenzioni[indexman] = m;
            indexman++;
        }
        public void DropManutenzioni()
        {
            manutenzioni = null;
        }
        public string GetAutore()
        {
            return this.autore;
        }

    }
}
