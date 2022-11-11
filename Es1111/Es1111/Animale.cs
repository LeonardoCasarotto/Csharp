using System;
using System.Collections.Generic;
using System.Text;

namespace Es1111
{
    public abstract class Animale
    {
        private string nome;
        private string verso;
        private string habitat;

        public abstract string Verso();

        public abstract string Vive();

        public abstract bool Mangia();
    }
}
