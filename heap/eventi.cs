using System;
class Program
    {

        static void Main(string[] args) 
        {
            // Creazione dell'oggetto che contiene la variabile 
            MyClass myObject = new MyClass();
            // Evento sottoscritto alla variabile dell'oggetto
            myObject.MyVariableChanged += MyEventHandler;
            // Cambio del valore della variabile (solleverà l'evento) 
            myObject.MyVariable = 42; 
        } 
            // Metodo che verrà chiamato al sollevamento dell'evento
        static void MyEventHandler(object sender, EventArgs e) 
        { 
            Console.WriteLine("La variabile ha cambiato valore!"); 
        }
    }
class MyClass
    {
        private int myVariable; 
        // Proprietà della variabile 
        public int MyVariable 
        { 

            get { return myVariable; } 
            set 
            { 
                myVariable = value; 
                // Sollevamento dell'evento al cambiamento della variabile 
                OnMyVariableChanged(); 
            } 



        } 
        
        
        
        
        
        
        
        // Definizione dell'evento 
        public event EventHandler MyVariableChanged; 
            // Metodo che solleva l'evento 
        protected virtual void OnMyVariableChanged() 
        { 
                MyVariableChanged?.Invoke(this, EventArgs.Empty); 
        }
    }

//