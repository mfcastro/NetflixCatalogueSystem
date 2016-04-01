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
        
        public List<Title> titleList = new List<Title>();

        public Genre(string genreType)
        {
            this.genreType = genreType;
        }

        public IEnumerator GetEnumerator()
        {
            for(int titleIndex = 0; titleIndex < titleList.Count; titleIndex++)
            {
                yield return titleList[titleIndex];
            }  
        }

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

        public static Genre operator + (Genre genre, Title title)
        {
            genre.titleList.Add(title);
            return genre;
        }

    }
}
