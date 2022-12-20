using System;
using System.Collections.Generic;
using System.Text;

namespace Es1220
{
    public class EventArgs
    {
        string name;

        

        private void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }






    }
}
