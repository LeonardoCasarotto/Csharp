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
    public partial class FormIns : Form
    {
        Prenotazioni pvett;

        public FormIns()
        {
            InitializeComponent();
        }

        public FormIns(Prenotazioni p)
        {
            pvett = p;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!pvett.Add(textBoxNome.Text, textBoxCognome.Text, dateTimePicker.Value, (DMI)comboBoxEsami.SelectedItem))
                MessageBox.Show("Impossibile aggiungere la prenotazione: spazio ESAURITO");

           
            this.Close();
        }


        private void FormIns_Load(object sender, EventArgs e)
        {
            for (int i=0; i<(int)DMI.Ecografia; i++)
            {
                comboBoxEsami.Items.Add((DMI)i);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
