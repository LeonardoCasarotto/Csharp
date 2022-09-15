using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmi_ricorsivi
{
    static class MyFunc
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMain());
        }

        public static int pow2(int num)
        {
            if (num == 0)
                return 1;
            else
                return num * pow2(num - 1);
        }
        public static int fatt(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else {
                return num * fatt(num - 1);
            }
        }

        public static int somma(int num)
        {
            if(num == 0)
            {
                return 0;
            }
            else
            {
                return num+somma(num - 1);
            }
        }
    }
}
