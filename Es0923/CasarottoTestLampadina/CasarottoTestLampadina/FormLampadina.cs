using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasarottoTestLampadina
{
    public partial class FormLampadina : Form
    {
        //new objects lampadina
        Lampadina prima = new Lampadina();
        Lampadina seconda = new Lampadina();

        public FormLampadina()
        {
            InitializeComponent();
            //get status of both lightbulbs
            textBox1.Text=prima.Stato();
            textBox2.Text = seconda.Stato();


        }

        //click lampadina 1
        private void button1_Click(object sender, EventArgs e)
        {
            prima.Click(prima.Stato(), prima.Cicli());
            textBox1.Text = prima.Stato();
            if (prima.Stato() == "rotta")
            {
                //if it's broken it asks the user if they wish to exit
                if (MessageBox.Show("La lampadina 1 è rotta, si desidera rimanere?", "Avviso", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                }
            }

        }

        //click lampadina 2
        private void button2_Click(object sender, EventArgs e)
        {
            seconda.Click(seconda.Stato(),seconda.Cicli());
            textBox2.Text = seconda.Stato();
            if (seconda.Stato() == "rotta")
            {
                
                if(MessageBox.Show("La lampadina 2 è rotta, si desidera rimanere?", "Avviso", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            
        }


       

        
    }
}
