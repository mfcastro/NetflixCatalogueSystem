using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    public class Genre : IEnumerable
    {
        public string genreType;
        
        //Contains a list of Titles
        public List<Title> titleList = new List<Title>();

        //Create the genres: All, Romance, Action, Comedy.They need to share some titles(such as Romantic Comedies)
        //      by reference, not by duplicating the title itself.
        public Genre(string genreType)
        {
            this.genreType = genreType;
        }

        //Implement custom iterator to iterate over those Titles
        public IEnumerator GetEnumerator()
        {
            for(int titleIndex = 0; titleIndex < titleList.Count; titleIndex++)
            {
                yield return titleList[titleIndex];
            }  
        }

        //Overload plus(+) operator to take in two Genres and return the aggregated Genre.
        // -For example, if we want to create an aggregated genre Romantic Comedy, all the film titles 
        //        in that specific genre would include film titles from Romance and film titles from Comedy
        public static Genre operator + (Genre genre1, Genre genre2)
        {
            if (genre1.Equals(genre2))
            {
                return genre1;
            }
            else
            {
                Genre genre = new Genre(String.Format("{0}-{1}", genre1.genreType, genre2.genreType));
                return genre;

            }
            
        }


        //Overload plus (+) operator to take in a Genre and a Title to return the aggregated Genre.
        // -Take in a title, add it to the genre, return an aggregated list.
        // -For example, title Die Hard and genre Comedy would return a list of all comedy films and Die Hard.
        public static Genre operator + (Genre genre, Title title)
        {
            genre.titleList.Add(title);
            return genre;
        }

    }
}
