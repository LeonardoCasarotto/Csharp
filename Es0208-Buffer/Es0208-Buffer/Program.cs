using System;
using System.Threading;
namespace Es0208_Buffer
{
    class Program
    {
        static void Main(string[] args)
        {
            shrdBuffer bf = new shrdBuffer();
            Produttore prod = new Produttore(bf);
            Consumatore cons = new Consumatore(bf);

            Thread tcons = new Thread(()=>cons.Consume());
            Thread tprod = new Thread(()=>prod.Produce());

            tprod.Start();
            tcons.Start();
            tprod.Join();
            tcons.Join();
        }
    }
}
