using System;
using System.Collections.Generic;
using System.Text;

namespace Es0203.Classes
{
    public class Barbiere
    {
        Queue<Cliente> Clienti;
        bool BarbiereAddormentato;
        public Barbiere()
        {
            BarbiereAddormentato = true;
            Clienti = new Queue<Cliente>();
        }

        public void Vivi()
        {
            while (Clienti.Count == 0)
            {


            }
            BarbiereAddormentato = false;
            Console.WriteLine("Il barbiere si è svegliato!");
            Taglia(Clienti.Dequeue().GetId());
        }
        public void Taglia(int k)
        {
            Console.WriteLine("Al cliente identificativo n."+k+" sono stati tagliati i capelli");
        }

        

    }
}
