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

        /*ASK ABOUT THIS*/
        public Show(string name, string rating, string genreType) : base(name, rating, genreType)
        {

        }



        //Overrides parent’s Rating to return an aggregated rating of Episode ratings

        //????????????????????????????????????

        

        //Overrides ToString() method to return a string of the name of the show and number of episodes

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
                string rating = Console.ReadLine();

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
