using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasarottoLupiPecore
{

    public partial class Form1 : Form
    {
        public static char[] lettere;
        
        public Form1()
        {
            InitializeComponent();

            string file = System.IO.File.ReadAllText(@"../../Pecore_Cavoli.csv"); //Lettura file
            file =file.Replace(";", "");// Rimuove il ;
            lettere = file.ToCharArray(); // Trasforma la stringa in un array di char

            lettere =MyFunc.Ordina(lettere);

            MessageBox.Show(MyFunc.Ordina(lettere).ToString());
           
        }
    }
}
