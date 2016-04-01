using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Show : Title 
    {
        public List<Episode> episodes = new List<Episode>();

        bool newEpisode = true;

        public Show(string name, double rating, string genreType) : base(name, rating, genreType)
        {

        }

       public void getAggregateRating(Show show)
        {
            double currentRating = 0;

            for(int i = 0; i < show.episodes.Count; i++)
            {
                currentRating += show.episodes[i].rating;
            }

            currentRating /= show.episodes.Count;

            show.rating = currentRating;
        }

      
        public static Show operator + (Show show, Episode episode)
        {
            show.episodes.Add(episode);
            return show;
        }

        public override string ToString()
        {
            return (String.Format("Name of Show: {0}, Number of Episodes {1}", this.name, episodes.Count));
        }


        public void createEpisode()
        {
            while (newEpisode)
            {
                Console.WriteLine("What is the Episode Titile?");
                string name =Console.ReadLine();

                Console.WriteLine("What is this Episode rated");
                double rating = Double.Parse(Console.ReadLine());

                episodes.Add(new Episode(name, rating));

                Console.WriteLine("Episode Created!");
                Console.WriteLine("Create another episode?");
                string answer = Console.ReadLine();

                if (answer.Equals("n"))
                {
                    newEpisode = false;
                }

            }

           
        }
    }
}
