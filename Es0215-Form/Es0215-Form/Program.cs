using Es0215_Form.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es0215_Form
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static Random rn;
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Form1 mainu = new Form1();
            //creo form e lo passo al bar
            Application.Run(mainu);
            rn = new Random();

            Bar b = new Bar(10,mainu);
            Barista barista1 = new Barista(b);
            Barista barista2 = new Barista(b);
            List<Thread> tcustomers = new List<Thread>();
            Thread tbarista1 = new Thread(barista1.Servi);
            Thread tbarista2 = new Thread(barista2.Servi);
            tbarista1.Start();
            tbarista2.Start();

            for (int i = 0; i < 12; i++)
            {
                Tipo tip = new Tipo();
                if (rn.Next(0, 2) == 0)
                {
                    tip = Tipo.locale;

                }
                else
                {
                    tip = Tipo.ospite;

                }

                Tifoso t = new Tifoso(b, tip, i);
                tcustomers.Add(new Thread(t.Pausa));
                tcustomers[i].Start();
                Thread.Sleep(rn.Next(0, 2300));
            }
            for (int i = 0; i < tcustomers.Count; i++)
            {
                tcustomers[i].Join();
            }
            b.end();


        }
    }
    }

