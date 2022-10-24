using System;
using System.Collections.Generic;
using System.Text;

namespace Es1024
{
    public class Motocicletta:Veicolo
    {
        private int Stroke;

        public Motocicletta(int id,string brand,int year,int cyl,int stroke) : base(id, brand, year, cyl)
        {
            Stroke = stroke;
        }
    }
}
