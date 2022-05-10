using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range
{
    public partial class Form1 : Form
    {
        float media;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int min = 0;
            int max = hScrollBar1.Value;
            listBox1.Items.Clear();
            Random rnd = new Random();
            int m = rnd.Next(min, max);
            for(int i = 0; i < 20; i++)
            {
                listBox1.Items.Add(m);
                media += m;
                m = rnd.Next(min, max);
            }
            media/= 20;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La media è: " + media);
        }
    }
}
