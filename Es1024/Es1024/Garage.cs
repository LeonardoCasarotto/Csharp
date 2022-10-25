using System;
using System.Collections.Generic;
using System.Text;

namespace Es1024
{
    public class Garage
    {
        private Veicolo[] gar;

        public Garage()
        {
            gar = new Veicolo[15];
        }

        public string GetSituazione()
        {
            string m = "";
            for(int i = 0; i < gar.Length; i++)
            {
                m += i + 1;
                if (gar[i] == null) m += "LIBERO";
                else m += "OCCUPATO";
            } 
            return m;
        }
        
    }
}
