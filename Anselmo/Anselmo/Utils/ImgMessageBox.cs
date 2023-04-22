using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anselmo.Utils
{
    public partial class ImgMessageBox : Form
    {

        public ImgMessageBox(string title, string msg, Image img)
        {
            InitializeComponent();
            this.Text = title;
            label1.Text = msg;
            label1.MaximumSize = new Size(300, 0);
            label1.AutoSize = true;
            pictureBox1.Image = img;
 
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        public void setMsg(string msg)
        {
            label1.Text = msg;
        }

        private void ImgMessageBox_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
