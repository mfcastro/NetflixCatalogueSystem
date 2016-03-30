using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    class Catalog
    {
        public List<Genre> genreList = new List<Genre>();

        public Genre all = new Genre("All");
        public Genre romance = new Genre("Romance");
        public Genre action = new Genre("Action");
        public Genre comedy = new Genre("Comedy");
        public Genre horror = new Genre("Horror");


        Movie dieHard = new Movie(1, 36, "Die Hard", "R");
        Show breakingBad = new Show("Breaking Bad", "R");


        public Catalog()
        {
            genreList.Add(all);
            genreList.Add(romance);
            genreList.Add(action);
            genreList.Add(comedy);
            genreList.Add(horror);
                   
        }
        

        public void addTiitleToAll()
        {
            all += dieHard;
            all += breakingBad;
        }
    }
}
