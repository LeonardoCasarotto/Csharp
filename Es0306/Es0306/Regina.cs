using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es0306
{
    public class Regina
    {
        private int XdellaRegina { get; set; }
        private int YdellaRegina { get; set; }
        public Regina(int XRegina, int YRegina)
        {
            this.XdellaRegina = XRegina;
            this.YdellaRegina = YRegina;
        }

        public bool ReginaSottoAttacco(Regina r)
        {
            bool ris = false;
            bool AttaccoInRiga = (this.XdellaRegina == r.XdellaRegina);
            bool AttaccoInColonna = (this.YdellaRegina == r.YdellaRegina);
            bool AttaccoInDiagonale = Math.Abs(this.XdellaRegina - r.XdellaRegina) == Math.Abs(this.YdellaRegina - r.YdellaRegina);

            if (AttaccoInRiga || AttaccoInColonna || AttaccoInDiagonale)
            {
                ris = true;
            }
            else
            {
                ris = false;
            }
            return ris;
        }

        public void Movimento(int x, int y, Regina re)
        {
            while (ReginaSottoAttacco(re))
            {
                if (x < 7)
                {
                    XdellaRegina++;
                }
                else if (x == 7&&y<7)
                {
                    XdellaRegina = 0;
                    YdellaRegina++;

                }
                else if(y==7 && x == 7)
                {
                    XdellaRegina = 0;
                    YdellaRegina = 0;
                }
            }
        }
    }


}