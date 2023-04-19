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
        public ImgMessageBox(string title, string message, Image im)
        {
            text = new Label();
            pictureBox1 = new PictureBox();
            this.Text = title;
            
            text.Text = message;
            pictureBox1.Image = im;
            pictureBox1.Enabled = true;
            pictureBox1.Width = im.Width;
            pictureBox1.Height = im.Height;
            pictureBox1.Visible = true;
       
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
