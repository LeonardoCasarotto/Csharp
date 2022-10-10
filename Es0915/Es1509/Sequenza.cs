using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es1509
{

    public partial class Sequenza : Form
    {
        public int[] geni;
        public int counter = 0;
        public Sequenza(int lungh)
        {
            InitializeComponent();

            geni = new int[lungh];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            geni[counter] = Convert.ToInt32(numericUpDown1.Value);
            counter++;
            

            if(counter == geni.Length)
            {
                MessageBox.Show("Inserimento terminato.. reindirizzamento");
                Form sts = new stats(geni);
                this.Hide();
                sts.ShowDialog();
                this.Close();

               
            }
            else
            {
                label1.Text = "Ora inserire il gene n. " + (counter + 1);
                numericUpDown1.Value = 0;

            }
        }
    }
}
