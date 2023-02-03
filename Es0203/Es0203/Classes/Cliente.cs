using System;
using System.Collections.Generic;
using System.Text;

namespace Es0203.Classes
{
    public class Cliente
    {
        int id;
        public int GetId()
        {
            return this.id;
        }
        public Cliente(int id)
        {
            this.id = id;
        }

        public void attesa()
        {

        }
        public void Taglio() { }
    }
}
