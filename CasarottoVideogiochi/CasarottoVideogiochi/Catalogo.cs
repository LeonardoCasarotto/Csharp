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
            int rows = File.ReadAllLines(@"../../../dep/dataset.csv").Length;
            games = new Videogioco[rows];


            //RESTART FROM HERE
            StreamReader st = new StreamReader(@" ../../../../../dep/dataset.csv");
            StreamWriter mt = new StreamWriter(@" ../../../../../dep/dataset.txt");
            for (int i = 0; i < rows; i++)
            {

                string[] line = st.ReadLine().Split(';');
                                


                games[i] = new Videogioco(line[0], line[1], float.Parse(line[2]), Convert.ToInt32(line[3]));


            }
            st.Close();
            mt.Close();







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




        

        

      


    }


}



