﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;


namespace CasarottoVideogiochi
{
      public class Catalogo
    {
        private Videogioco[] games;
        private int indice;





        //constructing method
       public Catalogo()
        {

            //counting the rows in the csv file and declarating the length of the array

            games = new Videogioco[200];



            StreamReader st = new StreamReader(@" ../../../../../dep/dataset.csv");
            indice = File.ReadAllLines(@"../../../dep/dataset.csv").Length;
            
            for (int i = 0; i < indice; i++)
            {

                string[] line = st.ReadLine().Split(';');



                games[i] = new Videogioco(line[0], line[1], float.Parse(line[2]), Convert.ToInt32(line[3]));


            }
            st.Close();

        }



        //get methods

        public Videogioco[] GetVideogioco()
        {
            return this.games;
        }

        public string GetName(int index)
        {
            return this.games[index].GeTitle();
        }

        public DateTime GetData(int index)
        {
            return this.games[index].GetDate();
        }

        public float GetPrice(int index)
        {
            return this.games[index].GetPrice();
        }

        public int GeTime(int index)
        {
            return this.games[index].GetDuration();
        }

        public int GetLength()
        {
            return this.indice-1;
        }
        
        


        //edit methods

        public void incrementIndex()
        {
            this.indice++;
        }
        //add a new voice
        public void newvoice(string title, DateTime data, float prezzo, int minuti)

        {
            string day = data.ToString("dd/MM/yyyy");
            this.games[indice - 1] = new Videogioco(title, day, prezzo, minuti);


            StreamWriter sw = new StreamWriter(@" ../../../../../dep/dataset.csv",true);

            sw.WriteLine(title+";"+ day+";"+ prezzo+";"+ minuti);
            sw.Close();


        }

        //remove a voice

        public bool RemoveVoice(string title)
        {
            bool m = false;
            StreamReader sr = new StreamReader(@" ../../../../../dep/dataset.csv");
            StreamWriter sw = new StreamWriter(@" ../../../../../dep/temp.csv");

            indice = File.ReadAllLines(@"../../../dep/dataset.csv").Length;

            for (int i = 0; i < indice; i++)
            {
                string[] line = sr.ReadLine().Split(';');
                if (line[0] != title)
                {
                    sw.WriteLine(line[0] + ";" + line[1] + ";" + line[2] + ";" + line[3]);
                }
                else m = true;
            }
            sr.Close();
            sw.Close();
            File.Delete(@" ../../../../../dep/dataset.csv");
            File.Move(@" ../../../../../dep/temp.csv", @" ../../../../../dep/dataset.csv");

            return m;

        }



        //sorting methods

        //sort by title
        public Catalogo SortByTitle(int right, Catalogo main)
        {

            if (right == 0)
            {

                return main;
            }

            for (int i = 0; i < right; i++)
            {
                if (String.Compare(this.games[i].GeTitle(), this.games[i + 1].GeTitle()) > 0)
                {
                    Videogioco appoggio = this.games[i];
                    this.games[i] = this.games[i + 1];
                    this.games[i + 1] = appoggio;
                }
            }
            right--;

            return SortByTitle(right, main);

        }

        //sort by date
        public Catalogo SortByDate(int right, Catalogo main)
        {
            if (right == 0)
            {

                return main;
            }

            for (int i = 0; i < right; i++)
            {
                if (DateTime.Compare(this.games[i].GetDate(), this.games[i + 1].GetDate()) > 0)
                {
                    Videogioco appoggio = this.games[i];
                    this.games[i] = this.games[i + 1];
                    this.games[i + 1] = appoggio;
                }
            }
            right--;

            return SortByDate(right, main);




        }
        //sort by price
        public Catalogo SortByPrice(int right, Catalogo main)
        {
            if (right == 0)
            {

                return main;
            }

            for (int i = 0; i < right; i++)
            {
                if (this.games[i].GetPrice() > this.games[i + 1].GetPrice())
                {
                    Videogioco appoggio = this.games[i];
                    this.games[i] = this.games[i + 1];
                    this.games[i + 1] = appoggio;
                }
            }
            right--;

            return SortByPrice(right, main);

        }
        //sort by game duration
        public Catalogo SortByTime(int right, Catalogo main)
        {
            if (right == 0)
            {

                return main;
            }

            for (int i = 0; i < right; i++)
            {
                if (this.games[i].GetDuration() > this.games[i + 1].GetDuration())
                {
                    Videogioco appoggio = this.games[i];
                    this.games[i] = this.games[i + 1];
                    this.games[i + 1] = appoggio;
                }
            }
            right--;

            return SortByTime(right, main);

        }

    }
}



