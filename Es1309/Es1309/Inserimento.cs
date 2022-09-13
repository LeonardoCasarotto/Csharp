using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es1309
{
    public partial class Inserimento : Form
    {
        public static string[] matricole;
        public static int[] punteggi;
        public int counter = 0;
        public Inserimento(int nstud)
        {
            InitializeComponent();
            matricole = new string[nstud];
            punteggi = new int[nstud];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Attenzione! Inserire i dati correttamente!");
                numericUpDown1.Value = 1;
                textBox1.Text = "";
            }
            else
            {
                matricole[counter] = textBox1.Text;
                punteggi[counter] = Convert.ToInt32(numericUpDown1.Value);
                numericUpDown1.Value = 1;
                textBox1.Text = "";
                counter++;
            }

            if (counter== matricole.Length)
            {
                MessageBox.Show("Tutti i dati sono stati inseriti.. reindirizzamento alla pagina risultati");
                Form res = new risultati(matricole,punteggi);
                this.Hide();
                res.ShowDialog();
                this.Close();
            }
            
        }

        
    }
}
