using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Es0215
{
    class Bar
    {
        int nmax;
        ConcurrentQueue<Tifoso> customers;
        object cli = new object();

        public Bar(int n)
        {
            this.nmax = n;
            customers =  new ConcurrentQueue<Tifoso>();
        }
        public void end()
        {

        }

        public void EntrataCliente()
        {


        }

        public void BarInFunzione()
        {

        }
    }
}
