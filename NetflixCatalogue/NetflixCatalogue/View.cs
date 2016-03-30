using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    class View
    {
        //Prints out the various Genres and their Titles
        public void printOutGenresAndTitles(Genre genre)
        {
            Console.WriteLine("{0}:", genre.genreType);
            foreach(Title title in genre)
            {
                Console.WriteLine(title.name);
            }
        }
    }
}
