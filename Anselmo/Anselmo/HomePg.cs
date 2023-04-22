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
        



        public HomePg()
        {
            InitializeComponent();

            hp = new HeapDrawer(flowLayoutPanel1, pictureBox1);
            albero = new Tree(hp);
            coniglioAnselmo = new Coniglio(albero);
            volpeTecla = new Volpe(albero);
            startBtn.BackColor = Color.FromArgb(255, 156, 126);
            stopBtn.BackColor = Color.FromArgb(255, 156, 126);

            threadConiglio = new Thread(coniglioAnselmo.Coniglia);
            threadConiglio.IsBackground = true;
            threadVolpe = new Thread(volpeTecla.Volpeggia);
            threadVolpe.IsBackground = true;

            Control.CheckForIllegalCrossThreadCalls = false;

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {





            albero.firstInsert(20);



            ImgMessageBox avviso = new ImgMessageBox("Inizio",
                                                     "Attenzione! Per l'inizio, il coniglio Anselmo ha giá inserito venti " +
                                                     "uccellini nell'albero", Properties.Resources._4);
            avviso.ShowDialog();

            hp.DrawHeap(albero.GetNdraw(),100,30,30,30);


        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            
            threadConiglio.Start();
            threadVolpe.Start();
            startBtn.Enabled = false;
            stopBtn.Enabled = true;




        }

        private void stopBtn_Click(object sender, EventArgs e)
        {

            stopBtn.Enabled = false;
            startBtn.Enabled = false;
            albero.funzia = false;
            



            ImgMessageBox end = new ImgMessageBox("Fine", "Il programma è finito, ci vediamo la prossima Pasqua!", Properties.Resources._3);
            end.ShowDialog();
        }
        


        private void Draw(object sender, EventArgs e)
        {
            hp.DrawHeap(albero.GetNdraw(), 100, 30, 30, 30);
        }



    }



}

