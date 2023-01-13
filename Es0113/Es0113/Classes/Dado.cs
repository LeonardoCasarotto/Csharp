using System;
using System.Collections.Generic;
using System.Text;

namespace Es0113.Classes
{
    public class Dado:Lancio
    {
        public Dado() { }

        public  int Lancia()
        {
            return new Random().Next(1, 7);
        }
    }
}
