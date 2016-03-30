using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    class Show : Title
    {
        //Contains a list of Episodes
        List<Episode> episodes = new List<Episode>();



        /*ASK ABOUT THIS*/
        public Show(string name, string rating) : base(name, rating)
        {
        }



        //Overrides parent’s Rating to return an aggregated rating of Episode ratings

        //????????????????????????????????????


        //Overrides ToString() method to return a string of the name of the show and number of episodes
        //public override string ToString()
        //{ 
        //    return (String.Format("Name of Show: {0}, Number of Episodes {1}",/*SHOW.name*/, episodes.Count));
        //}
    }
}
