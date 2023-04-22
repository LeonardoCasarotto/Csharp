using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using Anselmo.Classes;
using Anselmo.Utils;

namespace Anselmo
{
    public partial class HomePg : Form
    {
        public HeapDrawer hp;
        Tree albero;
        Coniglio coniglioAnselmo;
        Thread threadConiglio;
        Volpe volpeTecla;
        Thread threadVolpe;


        bool funzia = true;

        public HomePg()
        {
            InitializeComponent();

            hp = new HeapDrawer(flowLayoutPanel1, pictureBox1);
            albero = new Tree(hp);
            coniglioAnselmo = new Coniglio(albero);
            volpeTecla = new Volpe(albero);

            threadConiglio = new Thread(coniglioAnselmo.Coniglia);
            threadVolpe = new Thread(volpeTecla.Volpeggia);

            Control.CheckForIllegalCrossThreadCalls = false;

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {


            
            // stopBtn.Enabled = false;



            albero.firstInsert(10);




            ImgMessageBox avviso = new ImgMessageBox("Inizio",
                                                     "Attenzione! Per l'inizio, il coniglio Anselmo ha giá inserito dieci " +
                                                     "uccellini nell'albero", Properties.Resources._4);
            avviso.ShowDialog();

            hp.DrawHeap(albero.GetNdraw(),100,30,30,30);












            
            


                

           






            /* todo:
             * 1. inserimento primi uccellini
             * 2. dichiarazione e avvio thread
             * 3. evento per finire alla pressione di un pulsante
             
             
             
             */



        }

        private void startBtn_Click(object sender, EventArgs e)
        {


            // albero.Insert(rn.Next(0, 999), false);
            //hp.DrawHeap(albero.GetNdraw(), 100, 30, 30,30);
            /*pictureBox.Width += 10;
            pictureBox.Height += 10;*/
            threadConiglio.Start();
            threadVolpe.Start();




            


        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            
            albero.funzia = false;
            threadConiglio.Abort();
            threadVolpe.Abort();

            ImgMessageBox end = new ImgMessageBox("Fine", "Il programma è finito, ci vediamo la prossima Pasqua!", Properties.Resources._3);
        }
        


        private void Draw(object sender, EventArgs e)
        {
            hp.DrawHeap(albero.GetNdraw(), 100, 30, 30, 30);
        }

       





    }



}

