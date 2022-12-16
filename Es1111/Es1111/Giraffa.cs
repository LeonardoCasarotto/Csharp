using System;
using System.Collections.Generic;
using System.Text;

namespace Es1111
{
    public class Giraffa:Animale
    {
        public override string Nome()
        {
            return this.nome;
        }
        public override string Verso()
        {
            return "verso non identificabile";
        }
        public override bool Mangia(string cibo)
        {
            switch (cibo)
            {
                case "carne":
                    return false;
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
            return "savana";
        }

        public override void setNome(string name)
        {
            this.nome = name;
        }
    }
}
