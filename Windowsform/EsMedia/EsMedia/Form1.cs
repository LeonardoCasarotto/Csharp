using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox1.Items.Clear(); // delete all items in listbox
            int m;
            m = rnd.Next(1, 13);
            for (int i = 0; i < 13; i++)
                
            {
                
                listBox1.Items.Add(m);
                m = rnd.Next(1, 13);
            }
        }
    }
}
