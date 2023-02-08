using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0203_Console.Classes
{

    class barBuffer
    {

        Queue<Cliente> CodaClienti;  //clienti in attesa sulle sedie
        int nmaxsedie;
        Object SvegliaBarbiere; //these are objects for locking
        Object _Poltrona;
        Random rnd;
        Boolean isAllDone;


        public barBuffer(int nsedie)
        {

            CodaClienti = new Queue<Cliente>();
            nmaxsedie = nsedie;
            SvegliaBarbiere = new Object();
            _Poltrona = new Object();

            rnd = new Random();
            isAllDone = false;
        }

        public void finito()
        {
            isAllDone = true;
            lock (SvegliaBarbiere)  //il barbiere potrebbe essersi addormentato
                Monitor.PulseAll(SvegliaBarbiere);

        }

        public void arrivo_Cliente(Cliente cli)
        {
            lock (SvegliaBarbiere)
            {
                Cliente cliente = cli;
                /* inizio regione critica con accesso a risorse condivise*/
                if (CodaClienti.Count < nmaxsedie)  //se c'è ancora posto
                {
                    CodaClienti.Enqueue(cliente);       //cliente si accomoda

                    foreach (var c in CodaClienti)
                        Console.WriteLine($"cli "+c.id +" si è messo in coda");
                    Console.WriteLine();

                    Monitor.Pulse(SvegliaBarbiere); //prova a svegliare il barbiere,


                }
                else
                {
                    Console.WriteLine($"Negozio pieno, cliente {cliente.id} cerca un altro barbiere");
                    return;

                }
            }

            lock (_Poltrona) //_Poltrona viene usato per far stare effettivamente un solo cliente alla volta nel processo
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}" + " in attesa del barbiere");

                Monitor.Wait(_Poltrona);     //il cliente si mette in attesa
                                             //del servizio di taglio==poltrona
                Console.WriteLine($"{Thread.CurrentThread.Name}" + " è stato servito, va a casa");
                //servizio ottenuto 

            }



        }


        public void Servizio_Barbiere() //punto di entrata thread barbiere
        {
            while (!isAllDone)
            {
                Cliente cli;

                lock (SvegliaBarbiere) //un solo alla volta può accedere al barbiere
                {
                    if (CodaClienti.Count == 0)
                    {//barbiere si addormenta

                        Console.WriteLine("Il barbiere dorme sulla poltrona");
                        Monitor.Wait(SvegliaBarbiere);   //il thread del Barbiere va in waiting, aspettando
                    }                                   //che arrivi un cliente che svegli il barbiere

                    
                    CodaClienti.TryDequeue(out cli); //provo a rimuovere un cliente dalla poltrona
                }

                //proseguo verificando il sumero dei clienti
                lock (_Poltrona)
                {
                    //barbiere sveglio e c'è un cliente da servire
                    if (cli != null) // verifico che nella cosa ci sia 
                    { //fa alzare un cliente dalle sedie

                        Console.WriteLine("Taglio i capelli del cliente " + cli.id);    //se c'è almeno un cliente gli taglio i capelli
                        Thread.Sleep(rnd.Next(1, 1000));
                        Console.WriteLine("ho finito di tagliare i capelli del cliente " + cli.id);    

                        Monitor.Pulse(_Poltrona);   //riattiva (mette in stato ready) un thread Cliente in attesa di servizio
                    }
                }



            }
        }





    }
}
