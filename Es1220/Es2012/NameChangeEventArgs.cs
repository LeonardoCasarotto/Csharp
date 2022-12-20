using System;
using System.Collections.Generic;
using System.Text;

namespace Es1220
{
    public delegate void Notify(string g);
    //publisher
    public class NameChangeEventArgs:EventArgs
    {

        public event Notify Print;

        public void StartProcess()
        {
            Console.WriteLine("Inizio");
            Print?.Invoke(this.GetName());
            


        }
       

        

        
        

    }
}
