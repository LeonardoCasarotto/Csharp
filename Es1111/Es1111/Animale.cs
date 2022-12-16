using System;
using System.Collections.Generic;
using System.Text;

namespace Es1111
{
    public abstract class Animale
    {
        protected string nome="";

        public abstract string Verso();

        public abstract string Vive();

        public abstract bool Mangia(string cibo);

        public abstract string Nome();

        public abstract void setNome(string name);
    }
}
