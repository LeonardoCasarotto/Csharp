using System;
using System.Collections.Generic;
using System.Text;

namespace Es17p303
{
    public class Atleta
    {
        string nome;
        string nazionalità;
        int numeroGare;
        int annoNascita;

        public Atleta(string nam, string nat, int ng, int by)
        {
            this.nome = nam;
            this.nazionalità = nat;
            this.numeroGare = ng;
            this.annoNascita = by;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string nam)
        {
            this.nome = nam;
        }
        public string GetNazionalità()
        {
            return this.nazionalità;
        }
        public void SetNazionalità(string nat) 
        {
            this.nazionalità = nat;
        }
        public int GetNumeroGare()
        {
            return this.numeroGare;
        }
        public void SetNumeroGare(int n)
        {
            this.numeroGare = n;
        }
        public int GetAnnoNascita()
        {
            return this.annoNascita;
        }
        public void SetAnnoNascita(int n)
        {
            this.annoNascita = n;
        }

        public int età(int anno)
        {
            return anno - this.annoNascita;
        }

        public override string  ToString()
        {
            return "\nNome:\t" + this.nome + "\nNazionalità:\t" + this.nazionalità + "\nNumero Gare:\t" + this.numeroGare + "\nAnno di nascita:\t" + this.numeroGare;
        }

    
    
    
    }
}
