using System;
using System.Collections.Generic;
using System.Text;

namespace Es1111
{
    public class Gatto:Animale
    {
        public override string Nome()
        {
            return this.nome;
        }
        public override string Verso()
        {
            return "miao miao";
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
                    return true;
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
