using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace CasarottoVideogiochi
{
    class Catalogo
    {
        private Videogioco[] games;
        private int indice;





        //constructing method






        public Catalogo()
        {

            //counting the rows in the csv file and declarating the length of the array
            
            games = new Videogioco[200];


            //RESTART FROM HERE
            StreamReader st = new StreamReader(@" ../../../../../dep/dataset.csv");
            indice = File.ReadAllLines(@"../../../dep/dataset.csv").Length;
            for (int i = 0; i < indice; i++)
            {

                string[] line = st.ReadLine().Split(';');
                                


                games[i] = new Videogioco(line[0], line[1], float.Parse(line[2]), Convert.ToInt32(line[3]));


            }
            st.Close();
            







        }

        







        //get method

        public Videogioco[] GetVideogioco()
        {
            return this.games;
        }
        
        public string GetName(int index)
        {
            return this.games[index].GeTitle();
        }

        public string GetData(int index)
        {
            return this.games[index].GetDate().ToString("dd-MM-yyyy");
        }

        public float GetPrice(int index)
        {
            return this.games[index].GetPrice();
        }

        public int GeTime(int index)
        {
            return this.games[index].GetDuration();
        }



        

        

      


    }


}



