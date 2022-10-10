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
    public partial class FMain : Form
    {
        
       
        public FMain()
        {
            InitializeComponent();
            
           
        }

        private void FMain_Load(object sender, EventArgs e)
        {
           
            
        }

        
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (selezione.SelectedItem)
            {
                //2^N
                case "calcola 2^n":
                    
                    FDialog f = new FDialog(); //new form FDialog
                    if (f.ShowDialog() == DialogResult.OK) //if FDialog returned ok
                    {
                        int n = f.num;
                        int risultato = MyFunc.pow2(n); //calc
                        label_risultato.Text = "2^" + n + "= " + risultato;
                        label_risultato.Visible = true;
                    }
                    else
                        label_risultato.Text = "Cancelled";

                    f.Dispose();
                    break;


                //FATTORIALE
                case "fattoriale":
                    FDialog fd = new FDialog();
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        int n = fd.num;
                        int risultato = MyFunc.fatt(n);
                        label_risultato.Text = "fatt(" + n + ")= " + risultato;
                    }
                    else
                        label_risultato.Text = "Cancelled";
                    label_risultato.Visible = true;
                    fd.Dispose();
                    break;


                //SOMMA
                case "somma":
                    FDialog d = new FDialog();
                    if (d.ShowDialog()==DialogResult.OK){
                        int n = d.num;
                        int  risultato= MyFunc.somma(n);
                        label_risultato.Text = " "+risultato;

                    }
                    else
                    {
                        label_risultato.Text = "Cancelled";
                        label_risultato.Visible = true;
                        d.Dispose();
                    }
                    
                    break;


            }
        }
    }
}
