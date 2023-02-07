using System;
using System.Collections.Generic;
using System.Text;

namespace Es0203_Console.Classes
{
    public class Cliente
    {
        Negozio n;
        int id;

        public Cliente(Negozio m, int i)
        {
            n = m;
            id = i;
        }

        
        public void Entrata()
        {
            Console.WriteLine("Cliente "+id+" entra");
            Program.qu.RemoveAt(id+1);
            Program.th.RemoveAt(id);
        }


    }
}
