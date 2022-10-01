using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasarottoVideogiochi
{
    public class Videogioco
    {
        //attributes
        private string Title;
        private DateTime ReleaseDate;
        private float Price;
        private int Duration;


        //constructing methods

        public Videogioco(string title, string releaseDate,float price, int duration)
        {
            this.Title = title;
            this.ReleaseDate = Convert.ToDateTime(releaseDate);
            this.Price = price;
            this.Duration = duration;


        }

        //query methods
        public string GeTitle()
        {
            return this.Title;
        }
        public DateTime GetDate()
        {
            return this.ReleaseDate;
        }

        public float GetPrice()
        {
            return this.Price;

        }

        public int GetDuration()
        {
            return this.Duration;
        }





    }
}
