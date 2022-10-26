using System;
using System.Collections.Generic;
using System.Text;

namespace Es1024
{
    public class Veicolo
    {
        protected static int Id;
        protected static string Brand;
        protected static int Year;
        protected static int Cyl;


      public  Veicolo(int id,string brand,int year,int cyl)
        {
            
            
                Id = id;
                Brand = brand;
                Year = year;
                Cyl = cyl;
                
            
            
        }
       

        public int GetId()
        {
            return Id;
        }
        public string GetBrand()
        {
            return Brand;

        }
        public int GetYear()
        {
            return Year;
        }
        public int GetCyl()
        {
            return Cyl;
        }
        //TODO GET ID and keep count of it.
        
    }
}
