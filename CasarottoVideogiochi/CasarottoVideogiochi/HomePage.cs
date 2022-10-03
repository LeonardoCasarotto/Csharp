using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;
using System.Windows.Forms;

namespace CasarottoVideogiochi
{
    public  partial class HomePage :  KryptonForm
    {
        //create a new catalogo object
        Catalogo  ctl= new Catalogo();
        public HomePage()
        {
            InitializeComponent();
            //select default index for sorting combobox


            //initializing and customizing dgrid
            DataGridView dGrid = kryptonDataGridView1;

            dGrid.RowHeadersVisible = true;
            dGrid.SelectionMode = 0;
            dGrid.Width = 150 * 4 +30;
            dGrid.DefaultCellStyle.SelectionBackColor = Color.White;
            dGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            dGrid.ColumnCount = 4;
            dGrid.Columns[0].Name = "Titolo"; 
            dGrid.Columns[0].Width = 150;
            dGrid.Columns[1].Name = "Data";
            dGrid.Columns[1].Width = 150;
            dGrid.Columns[2].Name = "Prezzo";
            dGrid.Columns[2].Width = 150;
            dGrid.Columns[3].Name = "Minuti di Gioco";
            dGrid.Columns[3].Width = 120;
            dGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#d9e1f2"); ;
            dGrid.ReadOnly = true;
            dGrid.Visible = true;
            this.Controls.Add(dGrid);

            //filling  datagrid
            riempi();
            

            

            
        }

        //adding a new element
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormIns ins = new FormIns(ctl);
            
            ins.ShowDialog();
            riempi(); 
            
        }
        
        //calling sort methods
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = ctl.GetLength();
            switch (cmbSort.Text)
            {
                
                case "Titolo":

                    ctl = ctl.SortByTitle(length, ctl);
                    
                    break;
                case "Data di uscita":
                    ctl = ctl.SortByDate(length, ctl);
                    
                    break;
                case "Prezzo":
                    ctl = ctl.SortByPrice(length, ctl);
                    
                    break;
                case "Tempo di gioco":
                    ctl = ctl.SortByTime(length, ctl);
                    break;
            }
            riempi();
        }
       

        //function for updating datagrid
        private void riempi()
        {

            DataGridView dGrid = this.kryptonDataGridView1;
            dGrid.Rows.Clear();
            for (int i = 0; i < ctl.GetLength()+1; i++)
            {
                dGrid.Rows.Add(ctl.GetName(i), ctl.GetData(i).ToString("dd/MM/yyyy"), "€ "+ctl.GetPrice(i), ctl.GeTime(i));
            }


         }

        //exit from the application
        private void btnEsc_Click(object sender, EventArgs e)
        {
            DialogResult quit = MessageBox.Show("Si desidera davvero uscire?", "Esci", MessageBoxButtons.YesNo);
           if (quit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txRemove.Text.Length > 0)
            {
                ctl.RemoveVoice(txRemove.Text);
                ctl = new Catalogo();
                riempi();
            }
            else MessageBox.Show("Attenzione! Inserire i dati correttamente!", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
