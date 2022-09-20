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
            file =file.Replace(";","");// Rimuove il ;
            lettere = file.ToCharArray(); // Trasforma la stringa in un array di char

            
            lettere =MyFunc.Ordina(lettere,lettere.Length-1);
            label1.Text = "Array non ordinato: ";
            label2.Text = "Array ordinato: ";
            
            for(int i = 0; i < lettere.Length; i++)
            {
                label1.Text += file[i] + ";";

                label2.Text += lettere[i] +";";
            }
            
            

        }
    }
}
