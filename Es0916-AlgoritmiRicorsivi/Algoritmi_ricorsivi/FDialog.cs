using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmi_ricorsivi
{
    public partial class FDialog : Form
    {
        //public variable
        public int num;
        
        public FDialog()
        {
            InitializeComponent();
            num = 0;
            this.DialogResult = DialogResult.Cancel;
        }

        //textbox text changed
        private void textBox_num_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBox_num.Text, out num))         
                MessageBox.Show("Inserire un valore numerico");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; //when ok is pressed, return ok 
        }
    }
}
