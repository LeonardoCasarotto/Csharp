using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0203_Console.Classes
{
    class Cliente
    {
        static int prog = 0;
        public int id { get; } //setting id for tracking the customer no
        barBuffer shared;
        public Cliente(barBuffer neg)
        {

            id = prog++;
            shared = neg;

        }

        public void entrata_cliente()
        {
            shared.arrivo_Cliente(this);
        }
    }
}

