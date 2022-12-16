using System;
using System.Collections.Generic;
using System.Text;

namespace Es1111
{
    public class Cane:Animale
    {
        public override string Nome()
        {
            return this.nome;
        }
        public override string Verso()
        {
            return "bau bau";
        }
        public override bool Mangia(string cibo)
        {
            switch (cibo)
            {
                case "carne":
                    return true;
                case "vegetali":
                    return true;
                case "insetti":
                    return false;
                default:
                    return false;
            }
        }
        public override string Vive()
        {
            return "ambiente domestico";
        }

        public override void setNome(string name)
        {
            this.nome = name;
        }
    }
}
