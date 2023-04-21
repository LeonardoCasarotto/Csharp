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
        public HeapDrawer hp;

        private void Form1_Load(object sender, EventArgs e)
        {


            /*ImgMessageBox avviso = new ImgMessageBox("Inizio",
                                                     "Attenzione! Per l'inizio, il coniglio Anselmo ha giá inserito tre " +
                                                     "uccellini nell'albero",Properties.Resources._4);*/
            stopBtn.Enabled = false;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            panelTree.AutoScroll = true;
            

            hp = new HeapDrawer(panelTree,pictureBox);



            //avviso.ShowDialog();


            //inserimento dati
            albero.Insert(198);
            albero.Insert(840);
            albero.Insert(382);
            albero.Insert(541);
            albero.Insert(22);
            albero.Insert(777);
            albero.Insert(301);
            albero.Insert(665);
            albero.Insert(490);
            albero.Insert(915);
            albero.Insert(12);



            hp.DrawHeap(albero.GetNdraw(),100,30,30);  
           
            int[] arr = albero.GetNdraw();
            label1.Text = "[";
            for (int i = 0; i < arr.Length; i++)
            {
                label1.Text += arr[i] + ",";
            }



            
            


                

           






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

