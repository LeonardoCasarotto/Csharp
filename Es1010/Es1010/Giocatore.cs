using System;
using System.Collections.Generic;
using System.Text;

namespace Es1010
{
    
    public class Giocatore
    {
        private string name;
        private string surname;
        private DateTime birth;
        private int num;
        private string role;





        public Giocatore(string Name, string Surname,string Date,int Num,string Role)
        {
            this.name = Name;
            this.surname = Surname;
            this.birth = Convert.ToDateTime(Date);
            this.num = Num;
            this.role = Role;
        }

        public Giocatore(string Name,string Surname,DateTime Date,int Num, string Role)
        {
            this.name = Name;
            this.surname = Surname;
            this.birth = Convert.ToDateTime(Date);
            this.num = Num;
            this.role = Role;
        }

        //get
        public string GetName()
        {
            return this.name;
        }
        public string GetSurname()
        {
            return this.surname;
        }
        public DateTime GetBirth()
        {
            return this.birth;
        }
        public int GetNum()
        {
            return this.num;
        }
        public string GetRole()
        {
            return this.role;
        }

        //edit



    }
}
