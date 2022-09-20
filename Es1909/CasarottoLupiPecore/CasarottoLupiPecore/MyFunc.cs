using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasarottoLupiPecore
{
    static class MyFunc
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           

        }

        public static char[] Ordina(char[] lettere,int right)
        {
            if (right == 0)
                return lettere;

            for(int i = 0; i < right; i++)
            {
                if (lettere[i + 1] == 'c' || lettere[i] == 'l' && lettere[i+1] == 'p')
                {
                    char appoggio = lettere[i + 1];
                    lettere[i + 1] = lettere[i];
                    lettere[i] = appoggio;
                }
            }
            right--;
            return Ordina(lettere, right);

        }

    }
}
