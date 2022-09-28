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






        //constructing method






        public Catalogo()
        {

            //counting the rows in the csv file and declarating the length of the array
            int rows = File.ReadAllLines(@"../../../../dataset.csv").Length;
            games = new Videogioco[rows];


            //RESTART FROM HERE
            StreamReader st = new StreamReader(@".. / .. / .. / .. / dataset.csv");
            for(int i = 0; i < rows; i++)
            {
                
                string[] line = st.ReadLine().Split(' ', ';');
                games[i] = new Videogioco(line[0], line[1], float.Parse(line[2]), Convert.ToInt32(line[3]));


            }








        }




        //get method

        public Videogioco[] GetVideogioco()
        {
            return this.games;
        }




        

        

      


    }


}



