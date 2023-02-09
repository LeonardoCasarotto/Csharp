using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0126.Classes
{

    namespace CThreadWaitPulse_base
    {
        public class BufferCondiviso
        {
            private int buffer = -1;                  // buffer shared by producer and consumer threads  
            private int occupiedBufferCount = 0;
            // occupiedBufferCount si ricorda se                                      
            // (1) il buffer contiene un valore generato dal produttore e non ancora consumato,
            // NON si può scriverci sopra, si può consumare
            // (0) il valore del buffer è stato consumato,
            // si può scriverci sopra, NON si può consumare il suo valore


            static readonly object _locker = new object();
            public int Buffer
            {
                get  //lettore consumatore
                {
                    int bufferCopy;
                    lock (_locker)  //sezione critica
                                    //entra il thread che trova l'oggetto _locker libero
                    {
                        // se non ci sono dati da leggere
                        if (occupiedBufferCount == 0)
                        {   //mette il thread invocante nello stato WaitSleepJoin
                            Console.WriteLine(Thread.CurrentThread.Name + " prova a leggere");
                            //DisplayState("Buffer vuoto. " + Thread.CurrentThread.Name + " wait");
                            Monitor.Wait(_locker); //il thread va in waiting,
                                                   //rilascia _locker
                                                   //attende di essere risvegliato
                                                   //e di rientrare in possesso del _locker
                        }
                        --occupiedBufferCount;
                        DisplayState(Thread.CurrentThread.Name + " legge " + buffer);
                        bufferCopy = buffer;  //salvo su variabile locale al get
                        Monitor.Pulse(_locker);  //risveglia un thread dalla coda dei waiting
                                                 //notifica il rilascio del _locker

                    }
                    return bufferCopy;
                }
                set  //scrittore-produttore
                {
                    lock (_locker)   //sezione critica
                                     //entra il thread che trova l'oggetto _locker libero                     
                    {   //se non ci sono posizioni libere
                        if (occupiedBufferCount == 1)
                        {
                            //mette il thread di chiamata nello stato WaitSleepJoin
                            Console.WriteLine(Thread.CurrentThread.Name + " prova a scrivere");
                            DisplayState("Buffer pieno. " + Thread.CurrentThread.Name + " wait.");
                            Monitor.Wait(_locker);//il thread va in waiting,
                                                  //rilascia _locker
                                                  //attende di essere risvegliato
                                                  //e di rientrare in possesso del _locker
                        }

                        buffer = value;
                        ++occupiedBufferCount;
                        DisplayState(Thread.CurrentThread.Name + " scrive " + buffer);
                        Monitor.Pulse(_locker); //risveglia un thread dalla coda dei waiting
                                                //notifica il rilascio del _locker
                    }
                }
                //bufferCopy = buffer;  //salvo su variabile locale al get
            }

            // visualizza loperazione corrente e lostato del buffer 
            public void DisplayState(string operation)
            {
                //Un numero intero con segno che indica
                //la lunghezza totale del campo
                //in cui è inserito l'argomento e se lo è
                //allineato a destra (un numero intero positivo) o allineato a sinistra
                //(un numero intero negativo)
                Console.WriteLine($"{operation,-35}{buffer,-9}{occupiedBufferCount}");
            }
        } //end BufferCondiviso
    }
}
