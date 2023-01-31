using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Es0131.Classes
{

    
        public class BufferCondiviso
        {
            private Auto Macchina;                  // buffer shared by producer and consumer threads  
            private int occupiedBufferCount = 0;
            // occupiedBufferCount si ricorda se                                      
            // (1) il buffer contiene un valore generato dal produttore e non ancora consumato,
            // NON si può scriverci sopra, si può consumare
            // (0) il valore del buffer è stato consumato,
            // si può scriverci sopra, NON si può consumare il suo valore


            static readonly object _locker = new object();
            public Auto macchina
            {
                get  //lettore consumatore
                {
                    Auto bufferCopy;
                    lock (_locker)  //sezione critica
                                    //entra il thread che trova l'oggetto _locker libero
                    {
                        // se non ci sono dati da leggere
                        if (occupiedBufferCount == 0)
                        {   //mette il thread invocante nello stato WaitSleepJoin
                            Console.WriteLine(Thread.CurrentThread.Name + "prova a leggere");
                            DisplayState("Buffer vuoto. " + Thread.CurrentThread.Name + " wait");
                            Monitor.Wait(_locker); //il thread va in waiting,
                                                   //rilascia _locker
                                                   //attende di essere risvegliato
                                                   //e di rientrare in possesso del _locker
                        }
                        --occupiedBufferCount;
                        DisplayState(Thread.CurrentThread.Name + "legge " + Macchina);
                        bufferCopy = Macchina;  //salvo su variabile locale al get
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
                            Console.WriteLine(Thread.CurrentThread.Name + "prova a scrivere");
                            DisplayState("Buffer pieno. " + Thread.CurrentThread.Name + "wait.");
                            Monitor.Wait(_locker);//il thread va in waiting,
                                                  //rilascia _locker
                                                  //attende di essere risvegliato
                                                  //e di rientrare in possesso del _locker
                        }

                        Macchina = value;
                        ++occupiedBufferCount;
                        DisplayState(Thread.CurrentThread.Name + "scrive " + Macchina);
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
               // Console.WriteLine($"{operation,-35}{buffer}{occupiedBufferCount}");
            }
        } //end BufferCondiviso
    }
