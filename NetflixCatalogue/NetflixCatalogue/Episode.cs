using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Episode
    {
       public string episodeName;
        //Rating field
        public double  rating = 0;

        public Episode(string episodeName, double rating)
        {
            this.episodeName = episodeName;
            this.rating = rating;
        }

    }
}
