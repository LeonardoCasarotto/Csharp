using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Anselmo.Classes;
using Anselmo.Utils;

namespace Anselmo
{
    public partial class HomePg : Form
    {
        public HomePg()
        {
            InitializeComponent();
        }

        Tree albero = new Tree();

        private void Form1_Load(object sender, EventArgs e)
        {


            ImgMessageBox avviso = new ImgMessageBox("Inizio",
                                                     "Attenzione! Per l'inizio, il coniglio Anselmo ha giá inserito tre " +
                                                     "uccellini nell'albero",Properties.Resources._4);

            avviso.ShowDialog();

            albero.Aggiungi();
            albero.Aggiungi();
            albero.Aggiungi();

           



                

            /* todo:
             * 1. inserimento primi uccellini
             * 2. dichiarazione e avvio thread
             * 3. evento per finire alla pressione di un pulsante
             
             
             
             */



        }
    }
}
