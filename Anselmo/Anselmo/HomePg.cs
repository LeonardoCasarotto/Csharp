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
        Tree albero = new Tree();
        public HeapDrawer hp;
        Random rn;

        public HomePg()
        {
            InitializeComponent();
            rn = new Random();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {


            /*ImgMessageBox avviso = new ImgMessageBox("Inizio",
                                                     "Attenzione! Per l'inizio, il coniglio Anselmo ha giá inserito dieci " +
                                                     "uccellini nell'albero",Properties.Resources._4);*/
            stopBtn.Enabled = false;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            panelTree.AutoScroll = true;
            

            hp = new HeapDrawer(panelTree,pictureBox);



            //avviso.ShowDialog();


            //inserimento dati
           

            for(int i = 0; i < 10; i++)
            {
                albero.Insert(rn.Next(0, 999),false);
            }



            hp.DrawHeap(albero.GetNdraw(),100,30,30);  
           
           
           



            
            


                

           






            /* todo:
             * 1. inserimento primi uccellini
             * 2. dichiarazione e avvio thread
             * 3. evento per finire alla pressione di un pulsante
             
             
             
             */



        }

        private void startBtn_Click(object sender, EventArgs e)
        {

           
            stopBtn.Enabled = true;
            startBtn.Enabled = false;


        }

        
        



    }



}

