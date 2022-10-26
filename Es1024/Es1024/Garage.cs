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
                m += i + 1+".\t";
                if (gar[i] == null) m += "LIBERO\n";
                else m += "OCCUPATO\n";
            } 
            return m;
            
        }

        public bool parcheggia(int posto)
        {
            if (posto<gar.Length&&posto>0||gar[posto] != null) return true;
            else return false;
        }

        public void AddCar(int anno, int cilindrata, int doors, string marca,string alim, int id)
        {
            gar[id] = new Auto(id, marca, anno, cilindrata, doors, alim);
        }

        public void AddFurgone(int anno, int cilindrata, string marca, int id, float capacit)
        {
            gar[id] = new Furgone(id, marca, anno, cilindrata, capacit);
        }
        public void AddMoto(int anno, int id, int cilindrata, string marca,int stroke)
        {
            gar[id] = new Motocicletta(id, marca, anno, cilindrata, stroke); 
        }
        
        public void Esci(int id)
        {
            gar[id] = null;
        }
    }
}
