using System;
using System.Collections.Generic;
using System.Text;

namespace Es1024
{
    public class Auto:Veicolo
    {
        private int Doors;
        private string Power;


        public Auto(int id, string brand, int year, int cyl, int doors,string power) : base(id, brand, year, cyl) {
            Doors = doors;
            Power = power;
        }


    }
}
