using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                        Label l = new Label();
                        l.Dock = DockStyle.Fill;
                        l.TextAlign = ContentAlignment.MiddleCenter;
                        l.BackColor = (i + j) % 2 == 0 ? Color.White : Color.Black;
                        scacchiera.Controls.Add(l, i, j);
                    }
                }
                //make the window a square
                this.Width = this.Height;

                //make the window not resizable and appear in the center of the screen
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.StartPosition = FormStartPosition.CenterScreen;

                this.Controls.Add(scacchiera);
                





            }
        


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        public void Funzia()
        {
            for(int i = 0; i < 8; i++)
            {
                
             
                    Regina temp = new Regina(i, 0);
                    
                
                    if(reg.aTop>1)
                    {
                        Pila<Regina> rg = reg;
                        
                        for(int j = 0; j < rg.aTop; j++)
                        {
                            Regina t = rg.Pop();
                            temp.Movimento(i,0,t);
                            reg.Push(temp);
                            Aggiorna();
                        }
                    }

            }

        }
        public void Aggiorna()
        {
            Pila<Regina> h = reg;
            for (int i = 0; i < h.aTop; i++)
            {
                
            }
        }






    }
}
