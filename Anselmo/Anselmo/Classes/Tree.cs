using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anselmo.Classes
{
    public class Tree
    {

        MinHeap<Uccellino> albero = new MinHeap<Uccellino>();
        object _locker = new object();
        long _count = 0;


        public Tree()
        {
            

        }

        public void Togli()
        {
            lock (_locker)
            {
                albero.estrai();
            }
        }


        public void Aggiungi()
        {
            lock (_locker)
            {
                
                int rnd = new Random().Next(0, 1001);
                albero.Add(new Uccellino(_count, rnd));
                _count++;
            }
        }
    }
}
