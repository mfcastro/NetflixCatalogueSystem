using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Title
    {
        //Name field
        public string name;
        //Rating field
        public string rating;

        enum genre { Comedy,Romance,Action};
       
        // Offer two overloaded constructors: one that takes in all the fields and sets them
        public Title(string name, string rating)
        {
            this.name = name;
            this.rating = rating;
        }
        

        //       another that takes in no fields and sets the internal fields to null.
        public Title()
        {
            name = null;
            rating = null;
        }


        //Overload plus(+) operator to take in two Titles and return an aggregated Genre
        public static Title operator + (Title title1, Title title2)
        {
            //Implement!!!
            return null;
        }
           
       
    }
}
