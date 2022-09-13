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
    public partial class risultati : Form
    {
        public string[] studenti;
        public int[] punteggi;
        public float media = 0;
        public float bocciati = 0; 
        public risultati(string[] matricole, int[] voti)
        {
            InitializeComponent();
            studenti = matricole;
            punteggi = voti;
            ordinamento();
            stat();
            render();

        }

        public  void ordinamento()
        {
            for (int i=0; i < (punteggi.Length * (punteggi.Length - 1)) / 2; i++)
            {
                for(int l = 0; l < punteggi.Length - 1; l++)
                {
                    if (punteggi[l] < punteggi[l + 1])
                    {
                        int appoggint = punteggi[l + 1];
                        string appoggstr = studenti[l + 1];
                        punteggi[l + 1] = punteggi[l];
                        studenti[l + 1] = studenti[l];
                        studenti[l] = appoggstr;
                        punteggi[l] = appoggint;
                    }
                }
            }
        }

        public void stat()
        {
            for(int i = 0; i < punteggi.Length; i++)
            {
                media += punteggi[i];
                if (punteggi[i] < 60)
                {
                    bocciati++;
                }
            }
            media = media / punteggi.Length;
        }

        public void render()
        {
            label6.Text = media.ToString();
            label7.Text = ((bocciati/punteggi.Length)*100).ToString();
            label8.Text = (((punteggi.Length - bocciati) / punteggi.Length) * 100).ToString();
            label9.Text = studenti[studenti.Length - 1]+" con " + punteggi[punteggi.Length-1] ;
            label10.Text = studenti[0] + " con " + punteggi[0];

            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
