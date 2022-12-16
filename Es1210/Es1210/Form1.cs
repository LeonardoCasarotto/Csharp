using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es1210
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        int Y = 1;//per la posizione nello schermo
        List<Regalo> listareg = new List<Regalo>();
        public delegate void Deleg();//nuovo delegato
        public void Button()
        {
            Button btt = new Button();
            btt.Text = name.Text + " " + cognome.Text + " " + regalo.Text;
            btt.Name = counter.ToString();
            btt.Size = new Size(100, 100);//definisco la dimensione del bottone
            btt.BackColor = listareg[listareg.Count - 1].GetColor();
            btt.Location = new Point(350, 90 * Y);
            counter++;
            Y++;
            Controls.Add(btt);//aggiungo il bottone all'interfaccia
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Deleg d = Button;//assegno delegato a metodo button

            listareg.Add(new Regalo(name.Text, cognome.Text, regalo.Text));
            d();
            name.Text = "";
            cognome.Text = "";
            regalo.Text = "";
            MessageBox.Show("Regalo inserito con successo!");
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
