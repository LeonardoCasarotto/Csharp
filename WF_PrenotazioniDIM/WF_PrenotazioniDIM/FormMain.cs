using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_PrenotazioniDIM
{
    
    public partial class FormMain : Form
    {
        private Prenotazioni pren;

        public FormMain()
        {
            InitializeComponent();
            pren = new Prenotazioni();
            
            InitializeDataGrid();
        }
        //Initialization of data grid
        private void InitializeDataGrid()
        {
            dataGridPren.ColumnCount = 4;
            dataGridPren.Columns[0].Name = "Cognome";
            dataGridPren.Columns[1].Name = "Nome";
            dataGridPren.Columns[2].Name = "Data";
            dataGridPren.Columns[3].Name = "Esame";

            dataGridPren.AutoResizeColumns();

            dataGridPren.ReadOnly = true;  //controllo non editabile
            



        }
        //Insert an appointment
        private void button1_Click(object sender, EventArgs e)
        {
            FormIns FrmIns = new FormIns(pren);
            FrmIns.ShowDialog();
            // Show dialog block the execution of the code until the user fill the form
            //ShowForm instead doesn't block the execution of the code
            //dataGridPren.Rows.Clear();

            string[] row = new string[] {   pren.Last().Cognome,
                                            pren.Last().Nome,
                                            pren.Last().Dataprenot.ToLongDateString(),
                                            pren.Last().Esame.ToString() };
            dataGridPren.Rows.Add(row);


        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        
        //TODO create a a method to search the surname and mark it in the data grid

        private void aggiornaGrid(int nriga)
        {
            //clean the background
            for (int i = 0; i < dataGridPren.Rows.Count; i++)
            {
                dataGridPren.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
                dataGridPren.Rows[nriga].DefaultCellStyle.BackColor = Color.Yellow;
        }
    }
}
