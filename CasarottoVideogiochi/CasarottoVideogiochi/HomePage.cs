using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;
using System.Windows.Forms;

namespace CasarottoVideogiochi
{
    public  partial class HomePage :  KryptonForm
    {
        Catalogo  main= new Catalogo();
        public HomePage()
        {
            InitializeComponent();
            //select default index for sorting combobox
            

            //dgrid properties
            DataGridView dGrid = kryptonDataGridView1;

            dGrid.RowHeadersVisible = true;
            dGrid.SelectionMode = 0;
            dGrid.Width = 150 * 4 +30;
            dGrid.DefaultCellStyle.SelectionBackColor = Color.White;
            dGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            dGrid.ColumnCount = 4;
            //values
            dGrid.Columns[0].Name = "Titolo"; 
            dGrid.Columns[0].Width = 150;
            dGrid.Columns[1].Name = "Data";
            dGrid.Columns[1].Width = 150;
            dGrid.Columns[2].Name = "Prezzo";
            dGrid.Columns[2].Width = 150;
            dGrid.Columns[3].Name = "Minuti di Gioco";
            dGrid.Columns[3].Width = 120;
            dGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dGrid.ReadOnly = true;
            dGrid.Visible = true;
            this.Controls.Add(dGrid);

            //fill datagrid
            riempi();
            

            

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormIns ins = new FormIns(main);
            
            ins.ShowDialog();
            riempi();
            
            

            
            
            
        }
        

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = main.GetLength();
            switch (cmbSort.Text)
            {
                
                case "Titolo":

                    main = main.SortByTitle(length, main);
                    
                    break;
                case "Data di uscita":
                    main = main.SortByDate(length, main);
                    
                    break;
                case "Prezzo":
                    main = main.SortByPrice(length, main);
                    
                    break;
                case "Tempo di gioco":
                    main = main.SortByTime(length, main);
                    break;
            }
            riempi();
        }
       

            //function for updating datagrid
            private void riempi()
            {

            DataGridView dGrid = this.kryptonDataGridView1;
            dGrid.Rows.Clear();
            for (int i = 0; i < main.GetLength()+1; i++)
            {
                dGrid.Rows.Add(main.GetName(i), main.GetData(i).ToString("dd/MM/yyyy"), "€ "+main.GetPrice(i), main.GeTime(i));
            }


            }
        
    }
}
