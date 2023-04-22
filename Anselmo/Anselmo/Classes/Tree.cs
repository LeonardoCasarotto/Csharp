using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Anselmo.Utils;

namespace Anselmo.Classes
{
    public class Tree
    {

        MinHeap heap = new MinHeap(50);
        object _locker = new object();
        object _stampa = new object();
        bool edited = true;
        long _count = 0;
        ImgMessageBox ins = new ImgMessageBox("Aggiunta",
                                                 "Attenzione! Il coniglio Anselmo ha annunciato l'arrivo di un nuovo uccellino", Properties.Resources._2);
        ImgMessageBox rem = new ImgMessageBox("Rimozione",
                                                 "Attenzione! La volpe Tecla ha appena rimosso un uccellino!", Properties.Resources.wolf);



        public Tree()
        {
           

        }

        public void Remove(bool ann)
        {
            lock (_locker)
            {


                if(ann)rem.ShowDialog();
                heap.removeRight();

            }
        }


        public void Insert(int num,bool ann)
        {
            //lock (_locker)

                heap.Insert(new Uccellino(_count,num));
                _count++;
            if (ann) ins.ShowDialog();
            
                
                

            //}
        }

        public int[] GetNdraw()
        {
            lock ( _locker)
            {


                return heap.getHeap();


            }

        }






        
    }
}
