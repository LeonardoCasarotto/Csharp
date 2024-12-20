﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using System.IO;

namespace CasarottoVideogiochi
{
    public partial class FormIns : KryptonForm
    {


        public Catalogo ctl;
        public FormIns(Catalogo main)
        {
            InitializeComponent();

            ctl = main;
            

            

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            //checking input data

            if (check())
            {
                ctl.incrementIndex();

                ctl.newvoice(txTitle.Text, releaseDtp.Value, float.Parse(txPrice.Text), Convert.ToInt32(txTime.Text));

                MessageBox.Show("I dati sono stati inseriti con successo!");
                this.Close();
                
                
                
                


            }
            


        }
        private void errore()
        {
            MessageBox.Show("Attenzione! Inserire i dati correttamente!","Attenzione!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
         private bool check()
        {
            if(txTitle.Text.Length>0&&float.TryParse(txPrice.Text,out float c)){
                switch (cbUnit.SelectedItem)
                {
                    case null:
                        errore();
                        return false;
                        
                    case "Minuti":
                        if(Int32.TryParse(txPrice.Text, out int m)==false)
                        {
                            errore();
                            

                            return false;
                        }
                        break;
                        
                    case "Ore":
                        
                        if (float.TryParse(txTime.Text, out float z) == false)
                        {
                            errore();

                            return false;
                        }
                        else
                        {

                            txTime.Text = (z*60).ToString();
                        }
                        
                        
                        break;
                        
                        
                }
                return true;

            }
            errore();
            return false;
        }

        
    }
}
