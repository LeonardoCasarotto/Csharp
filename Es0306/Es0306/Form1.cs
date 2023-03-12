using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Es0306
{
    public partial class NQueens : Form
    {

        public Pila<Regina> reg = new Pila<Regina>();
        TableLayoutPanel scacchiera;
        public NQueens()
        {
            InitializeComponent();
    
            
            
                InitializeComponent();
                scacchiera = new TableLayoutPanel();

                scacchiera.ColumnCount = 8;
                scacchiera.RowCount = 8;
                scacchiera.Dock = DockStyle.Fill;

                scacchiera.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                scacchiera.ColumnStyles.Clear();
                scacchiera.RowStyles.Clear();
                //create a chess board with alternating colors and all squares being same size and filling the form

                for (int i = 0; i < 8; i++)
                {
                    scacchiera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
                    scacchiera.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
                }

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        PictureBox p = new PictureBox();
                        p.Dock = DockStyle.Fill;
                        
                        p.Image = (i + j) % 2 == 0 ? Image.FromFile("../../white.png") : Image.FromFile("../../black.png");
                        scacchiera.Controls.Add(p, i, j);
                    }
                }
                //make the window a square
                this.Width = this.Height;

                //make the window not resizable and appear in the center of the screen
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.StartPosition = FormStartPosition.CenterScreen;
                //scacchiera.BackColor = Color.Blue;

                this.Controls.Add(scacchiera);
                

                





            }
        


        private void Form1_Load(object sender, EventArgs e)
        {

            
            
        }
        public void Funzia()
        {
            reg.Push(new Regina(0, 0));
            for (int i = 1; i < 8; i++)
            {
                Regina temp = new Regina(0, 0);

                temp.Movimento(reg.Pop());
                reg.Push(temp);

                Aggiorna(temp.XdellaRegina, temp.YdellaRegina);
            }
        }


        public void Aggiorna(int x, int y)
        {
             var m = scacchiera.GetControlFromPosition(x, y);
            scacchiera.Controls.Remove(m);
            
            PictureBox p = new PictureBox();
            p.Dock = DockStyle.Fill;
            

            p.Image = (x + y) % 2 == 0 ? Image.FromFile("../../whitequeen.png") : Image.FromFile("../../blackqueen.png");

            scacchiera.Controls.Add(p, x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funzia();
        }
    }
}
