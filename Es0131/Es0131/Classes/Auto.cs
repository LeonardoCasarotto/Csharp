using System;
using System.Collections.Generic;
using System.Text;

namespace Es0131.Classes
{
    public class Auto
    {
        string targa;
        int? id;

        public Auto(string trg)
        {
            this.targa = trg;
        }

        public void SetId(int i)
        {
            this.id = i;
        }
        public int? GetId()
        {
            return id;
        }



    }
}
