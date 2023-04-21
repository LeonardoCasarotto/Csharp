﻿using System;
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
        HeapDrawer hp;

        private void Form1_Load(object sender, EventArgs e)
        {


            /*ImgMessageBox avviso = new ImgMessageBox("Inizio",
                                                     "Attenzione! Per l'inizio, il coniglio Anselmo ha giá inserito tre " +
                                                     "uccellini nell'albero",Properties.Resources._4);*/
            stopBtn.Enabled = false;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            panelTree.AutoScroll = true;
            int[] heap = new int[] { 35, 33, 43, 10, 14, 19, 27 };

            hp = new HeapDrawer(panelTree,pictureBox);
            


            //avviso.ShowDialog();
            

            albero.Aggiungi();
            albero.Aggiungi();
            albero.Aggiungi();
            hp.DrawHeap(heap,100,30,30);  



            
            


                

           






            /* todo:
             * 1. inserimento primi uccellini
             * 2. dichiarazione e avvio thread
             * 3. evento per finire alla pressione di un pulsante
             
             
             
             */



        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            hp.DrawHeap();
            stopBtn.Enabled = true;
            startBtn.Enabled = false;


        }

        
        



    }



}
