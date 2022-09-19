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

        public static char[] Ordina(char[] lettere)
        {
           
                int lg = lettere.Length;

                if (lg == 1)
                    return lettere;

                for (int i = 0; i < lg - 1; i++)
                {
                    switch (lettere[i])
                    {

                        case 'c':
                            if (lettere[i] > lettere[i + 1])
                            {

                                char temp = lettere[i + 1];
                                lettere[i + 1] = lettere[i];
                                lettere[i] = temp;

                            }

                            break;

                        case 'p':
                            if (lettere[i + 1] == 'c')
                            {
                                char temp = lettere[i + 1];
                                lettere[i + 1] = lettere[i];
                                lettere[i] = temp;
                            }
                            break;

                        case 'l':
                            if (lettere[i + 1] != 'l')
                            {
                                char temp = lettere[i + 1];
                                lettere[i + 1] = lettere[i];
                                lettere[i] = temp;
                            }
                            break;

                    }
                }
                

                return Ordina(lettere);
            


        }

    }
}
