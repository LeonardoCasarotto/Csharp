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
    public partial class stats : Form
    {
        public int[] geni ;
         
        public int[] volte = { 0, 0, 0, 0, 0, 0, 0, 0, 0,0 };
        public int magg = 0;
        public stats(int[] ge)
        {
            InitializeComponent();
            geni = ge;

            bubble();
            conta();
            mag();
           
            listBox1.Items.Clear();
            //sequenza ordinata
            for(int i = 0; i < geni.Length; i++)
            {
                listBox1.Items.Add(geni[i]);
            }

            label2.Text = "il gene che si presenta il maggior numero di volte è "+magg;
            listBox2.Items.Clear();

            //ricorrenza
            for(int i=0; i < volte.Length; i++)
            {
                listBox2.Items.Add(i+"\t -->\t"+volte[i]);
            }

        }

        public void bubble()
        {
            for(int i = 0; i < (geni.Length * (geni.Length - 1)) / 2; i++)
            {
                for(int l=0;l< (geni.Length - 1); l++)
                {
                    int app;
                    if (geni[l] > geni[l + 1])
                    {
                        app = geni[l];
                        geni[l] = geni[l + 1];
                        geni[l + 1] = app;
                    }
                }
            }
        }

        public void conta()
        {

            for( int i = 0; i < geni.Length; i++)
            {
                volte[geni[i]]++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("il  gene " + numericUpDown1.Value + " si verifica " + volte[Convert.ToInt32(numericUpDown1.Value)] + " volte.");
        }


        public void mag()

        {
            

            for (int x = 0; x < volte.Length-1; x++)
            {

               if( volte[magg] < volte[x])
                {
                    magg = x;
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }




    
}
