using System;
using System.Threading;

namespace Es0119
{
    enum Tipo{
        add,sub

    }
    class Program
    {
        static int num1 = 200;
        static int num2 = 300;
        
        static void Main(string[] args)
        {
            int qta;
            Console.WriteLine("Inserire quantità");
            int.TryParse(Console.ReadLine(), out qta);

            Shift s1 = new Shift(qta,Tipo.add);
            Shift s2 = new Shift(qta, Tipo.sub);


            Thread t1 = new Thread(Operazione);
            //otherwise we can use the following function:
            //Thread t1 = new Thread(() =>Operazione(qta,Tipo.add));
            t1.Start(s1);
            //We must change also the second thread
            Thread t2 = new Thread(Operazione);
            
            t2.Start(s2);

            t1.Join();
            t2.Join();
            Console.WriteLine("Numero 1 uguale a "+num1+"\nNumero 2 uguale a "+num2);

        }
        //obviously using the lambda function we must change the parameters of the method operazione
        // static void Operazione(int q,Tipo m)
        static void Operazione(object o)
        {
            Shift s = o as Shift;
            switch (s.operazione)
            {
                case Tipo.add:
                    num1 += s.qta;
                    break;
                case Tipo.sub:
                    num2 -= s.qta;
                    break;
            }
        }
    }
    
    //object shift for passing the quantity as a parameter
    class Shift
    {
        public int qta { get; set; }
        public Tipo operazione;

        public Shift(int q, Tipo operazione)
        {
            this.qta = q;
            this.operazione = operazione;
        }
    }
}
