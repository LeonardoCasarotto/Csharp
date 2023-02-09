<h1><b>Note per capire il funzionamento dell'esercizio</b></h1>
<p float="left">Nel codice del barbiere dormiente vengono usati vari elementi che è bene annotare per ricordarmi il funzionamento:</p>

<details>
    <summary><b>Lock(obj){ }</b></summary>
    <p>Inserire un pezzo di codice nel lock, che accetta come parametro un oggetto ci consente di assicurarsi l'accesso esclusivo ad una risorsacondivisa. Un solo thread per volta può acquisire tale oggetto con questa istruzione. </p>

```c#

        using System;
        using System.Threading;
        using static System.Console;
        class Program
        {
            private static object _locker = new object();
            static int k=0;
            static void Increase(string n){
                lock(_locker){
                    k++;
                    WriteLine(n+" ha incrementato");
                }
            }
            static void First(){
                for(int i=0;i<10;i++){
                    Increase("proc1");
                }
            }
            static void Second(){
                for(int i=0;i<10;i++){
                    Increase("proc2");
                }
            }
                
                
            static void Main() 
            {
                Thread t1 = new Thread(()=>First());
                Thread t2 = new Thread(()=>Second());
                
                t1.Start();
                t2.Start();
                t1.Join();
                t2.Join();
                WriteLine("Il risultato uguale a "+k);
            }
    
    
        }

```

<p>Nell'esempio soprastante vediamo come la funzione lock viene usata per far entrare un solo processo alla volta nella funzione <b>Increase()</b>.</p>

</details>

<details>
    <summary><b>Monitor.Wait(obj), Monitor.Pulse(obj)</b></summary>
    <p>Lo scopo di questi due metodi è quello di fornire un metodo di segnalazione, in particolare il thread che riceve il wait, viene messo in pausa sino a quando non riceve il pulse da un altro thread. Ambo i metodi ricevono come parametro un oggetto.</p>

```c#

    using System;
    using System.Threading;
    using static System.Console;
        class Program
        {
            private static object _locker = new object();
            private static bool _flag = false;
            
            static void Pinco(){
                
                for(int i=0;i<10;i++){
                lock(_locker){
    
                    Write(i+"\tpinco ");
                    _flag=true;
                    Monitor.Pulse(_locker);
                    Monitor.Wait(_locker);
                
                        
                    }
                }
            }
            static void Pallino(){
            

                for(int i=0;i<10;i++){
                    lock(_locker){
                        while(!_flag){
                            Monitor.Wait(_locker);
                        }
                    _flag=false;
                    Write("pallino\n");
                    Monitor.Pulse(_locker);
                    Monitor.Wait(_locker);
                    
                    
                    }
            }
                
                
            }
            static void Main() 
            {
                Thread t1 = new Thread(()=>Pinco());
                Thread t2 = new Thread(()=>Pallino());
                
                t1.Start();
                t2.Start();
                t1.Join();
                t2.Join();
            }
    
    
        }

```

<p>Nel codice soprastante possiamo notare l'alternanza dell'attività tra sue threads per scrivere "pinco pallino", nota che il <b>Monitor.Pulse</b> viene sempre chiamato prima del <b>Monitor.Wait</b>, in modo tale da poter sbloccare il processo successivo prima di bloccare quello corrente.</p>

</details>
