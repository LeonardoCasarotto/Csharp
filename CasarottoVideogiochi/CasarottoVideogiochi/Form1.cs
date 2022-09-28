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
    public partial class HomePage : KryptonForm
    {
        public HomePage()
        {
            InitializeComponent();
            Catalogo main = new Catalogo();

            DataGridView dGrid = kryptonDataGridView1;

            dGrid.RowHeadersVisible = true;
            dGrid.SelectionMode = 0;
            dGrid.DefaultCellStyle.SelectionBackColor = Color.White;
            dGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            dGrid.ColumnCount = 6;
            //values
            dGrid.Columns[0].Name = "Titolo"; 
            dGrid.Columns[0].Width = 150;
            dGrid.Columns[1].Name = "Data";
            dGrid.Columns[1].Width = 150;
            dGrid.Columns[2].Name = "Prezzo";
            dGrid.Columns[2].Width = 150;
            dGrid.Columns[3].Name = "Tempo";
            dGrid.Columns[3].Width = 120;
            
            dGrid.ReadOnly = true;
            dGrid.Visible = true;
            this.Controls.Add(dGrid);

            for(int i = 0; i < 25; i++)
            {
                dGrid.Rows.Add(main.GetName(i));
            }
        }

    }
}
