using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
   public class Movie : Title
    {
        
        int hours;
        int minutes;

        public Movie(int hours, int minutes, string name, double rating, string genreType) : base(name, rating, genreType)
        {
            this.hours = hours;
            this.minutes = minutes;
        }


        public string duration
        {
            get
            {
                return String.Format("{0}h {1:00}mins", this.hours, this.minutes);
            }
        }


        
        public override string ToString()
        {
            return (String.Format("Name of Show: {0}, Duration of Movie: {1}",this.name, this.duration));
        }

        public void createEpisode()
        {
            Console.WriteLine("This is a movie. You can't add episodes to it");
        }
    }
}
