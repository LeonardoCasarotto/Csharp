using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es0203
{
    class Poltrona
    {
        Queue<Cliente> clienti;
        bool occupata;
        private readonly object lockObj = new object();

        public Poltrona()
        {

            while (true)
            {

                while (occupata)
                {

                }
                while (clienti.Count == 0)
                {
                    //out dormi
                }
                
            }
        }

        public void NewCliente(Cliente c)
        {
            clienti.Enqueue(c);
        }

    }
}
