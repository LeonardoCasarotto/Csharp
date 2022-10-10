using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Es1010
{
    public class Squadra
    {
        private Giocatore[] team;
        private int indice;


        public Squadra()
        {
            team = new Giocatore[30];

            StreamReader st = new StreamReader(@" ../../../../../dep/dataset.csv");
            indice = File.ReadAllLines(@"../../../dep/dataset.csv").Length;

            for (int i = 0; i < indice; i++)
            {

                string[] line = st.ReadLine().Split(';');



                team[i] = new Giocatore(line[0], line[1],line[2], Convert.ToInt32(line[3]),line[4]);


            }
            st.Close();
        }

        //get
        public Giocatore[] GetGiocatore()
        {
            return this.team;
        }
        public string GetNome(int index)
        {
            return this.team[index].GetName();
        }
        public string GetCognome(int index)
        {
            return this.team[index].GetSurname();

        }
        public DateTime GetBirth(int index)
        {
            return this.team[index].GetBirth();
        }

        public int GetNum(int index) 
        {
            return this.team[index].GetNum();

        }

        public string GetRole(int index)
        {
            return Convert.ToString(this.team[index].GetRole());
        }
        public int GetIndice()
        {
            return this.indice;
        }

        public Squadra Sort(Squadra team,int left, int right)
        {
            if (this.GetNum(left) < this.GetNum(right))
            {
                int middle = left + (right - left) / 2;

                Sort(team, left, middle);
                Sort(team, middle + 1, right);

            }
            return team; 
        }

        public void Merge(Squadra team, int left, int middle, int right)
        {
            
            
            


        }
    }
}
