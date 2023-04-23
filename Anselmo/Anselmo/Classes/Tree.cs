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

        MinHeap heap;
        object _stampa;
        Random rn;
        public bool funzia { get; set; } = true;








        long _count = 0;
        ImgMessageBox ins = new ImgMessageBox("Aggiunta",
                                                 "Attenzione! Il coniglio Anselmo ha annunciato l'arrivo di un nuovo uccellino", Properties.Resources._2);
        ImgMessageBox rem = new ImgMessageBox("Rimozione",
                                                 "Attenzione! La volpe Tecla ha appena rimosso un uccellino!", Properties.Resources.wolf);
        public HeapDrawer hp;








        public Tree(HeapDrawer h)
        {
            heap = new MinHeap(5);
            this.hp = h;
            _stampa = new object();
            rn = new Random();

            
        }




        public void Remove(bool ann)
        {
            while (funzia)
            {




                Uccellino tmp = heap.removeRight();


                if (tmp != null)
                {
                    rem.setMsg("La volpe Tecla ha rimosso l'uccellino identificativo " + tmp.id + " con valore " + tmp.number);
                    if (ann) rem.ShowDialog();
                    lock (_stampa)  hp.DrawHeap(this.GetNdraw(), 100, 30, 30, 30);

                    Thread.Sleep(rn.Next(500,5500));
                }

            }
                    

                
            
        }


        public void Insert(bool ann)
        {

            while (funzia)
            {

                    heap.Insert(new Uccellino(_count, rn.Next(0, 999)));
                    _count++;
                    
                    lock(_stampa) hp.DrawHeap(this.GetNdraw(), 100, 30, 30, 30);
;
                    ins.ShowDialog();

                    Thread.Sleep(rn.Next(500,5500));


             }


        }



            
        


        public void firstInsert(int num)
        {

            for (int i = 0; i < num; i++)
            {
                heap.Insert(new Uccellino(_count, rn.Next(0, 999)));
                _count++;
            }
        }

        public int[] GetNdraw()
        {

                return heap.getHeap();


        }



    }
}
