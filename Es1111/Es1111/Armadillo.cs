using System;
using System.Collections.Generic;
using System.Text;

namespace Es1111
{
    public class Armadillo:Animale
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
                    return true;
                default:
                    return false;
            }
        }
        public override string Vive()
        {
            return "aree subtropicali";
        }

        public override void setNome(string name)
        {
            this.nome = name;
        }
    }
}
