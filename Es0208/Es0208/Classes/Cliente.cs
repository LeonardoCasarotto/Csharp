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
        public string nome { get; set; }
        public TypeCli tipo { get; set; }

        public Cliente(Pizzeria pizz, TypeCli c, string n)
        {
            //todo complete the variable assignment
        }



        public void run()
        {
            //shared.entrata_pizzeria();
        }

    }
}
