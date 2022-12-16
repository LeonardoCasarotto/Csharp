using System;
using System.Collections.Generic;
using System.Text;

namespace Es17p303
{
    public class Nuotatore:Atleta
    {
        string stile;
        int tempo100;
        int tempo200;

        public Nuotatore(string nam, string nat, int ng,int by,string st,int cento,int duecento): base(nam, nat, ng, by)
        {
            this.stile = st;
            this.tempo100 = cento;
            this.tempo100 = duecento;
        }
        public string GetStile()
        {
            return this.stile;  
        }
        public void SetStile(string stil)
        {
            this.stile = stil;
        }
        public int GetCento()
        {
            return this.tempo100;
        }
        public void SetCento(int time)
        {
            this.tempo100 = time;
        }
        public int GetDuecento()
        {
            return this.tempo200;
        }
        public void SetDuecento(int time)
        {
            this.tempo200 = time;
        }
        public  string Nuota()
        {
            return "ok";
        }
    }
}
