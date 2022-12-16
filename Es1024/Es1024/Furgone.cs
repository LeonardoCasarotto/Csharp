using System;
using System.Collections.Generic;
using System.Text;

namespace Es1024
{
    public class Furgone:Veicolo
    {
        private float Capacity;

        public Furgone(int id, string brand, int year, int cyl, float capacity) : base(id, brand, year, cyl)
        {
            Capacity = capacity;
        }
    }
}
