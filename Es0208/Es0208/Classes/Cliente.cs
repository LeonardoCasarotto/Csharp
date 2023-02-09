using System;
using System.Collections.Generic;
using System.Text;

namespace Es0208.Classes
{
    enum TypeCli{
        inPresenza, daRemoto
    }
    class Cliente
    {
        Pizzeria shared;
        static int pr = 0;
        public int id { get; set; }
        public TypeCli tipo { get; set; }

        public Cliente(Pizzeria pizz, TypeCli c)
        {
            shared = pizz;
            tipo = c;
            id = pr++;
        }



        public void run()
        {
            shared.entrata_pizzeria(this);
        }

    }
}
