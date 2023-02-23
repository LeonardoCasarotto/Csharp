using Es0215_Form.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Es0215_Form
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            redCounter.Text = "0";
            redSemaphore.Text = "ATTENDI";
            blueCounter.Text = "0";
            blueSemaphore.Text = "ATTENDI";

            
        }





        public void Pulizia() 
        {
            Tipo temp;

            if (blueSemaphore.Text == "ACCEDI") temp = Tipo.locale;
            else temp = Tipo.ospite;


            //bar.Controls.Add(pulizie);
            
           
            pulizie.Visible = true;

            Thread.Sleep(5000);

            pulizie.Visible = false;



        }

        public void CgTeam(Tipo squadra) 
        {
        
            
        
        
        }

        public void Counter(Tipo squadra,int change) 
        {
            switch (squadra)
            {
                case Tipo.locale:
                    int tem = Convert.ToInt32(this.redCounter.Text) + change;
                    this.redCounter.Text = tem.ToString();

                    break;
                case Tipo.ospite:
                    int temp = Convert.ToInt32(this.blueCounter.Text)+change;
                    this.blueCounter.Text = temp.ToString();
                    break;
            }
        }

      
    }
}
