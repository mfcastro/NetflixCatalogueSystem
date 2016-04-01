using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Title
    {
   
        public string name;
        public double ? rating;
        public string genreType;


        //enum genre { Comedy,Romance,Action};
       
        public Title(string name, double rating, string genreType)
        {
            this.name = name;
            this.rating = rating;
            this.genreType = genreType;
        }
        
        public Title()
        {
            name = null;
            rating = null;
        }


        //Overload plus(+) operator to take in two Titles and return an aggregated Genre
        public static Genre operator + (Title title1, Title title2)
        {
            Genre newGenre = new Genre(String.Format("{0}-{1}", title1.genreType, title2.genreType));
            newGenre.titleList.Add(title1);
            newGenre.titleList.Add(title2);

            return newGenre;
        }
           
       
    }
}
