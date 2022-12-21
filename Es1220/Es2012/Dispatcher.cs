using System;
using System.Collections.Generic;
using System.Text;

namespace Es1220
{
    public class Dispatcher
    {
        string nome;
        
        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string n)
        {
            this.nome = n;
            OnNameChange(new NameChangeEventArgs(n));
        }
        public event EventHandler<NameChangeEventArgs> NameChange;//dichiaro evento
        protected void OnNameChange(NameChangeEventArgs e) => NameChange?.Invoke(this, e);//if is not null, invoke the method
    }
}
