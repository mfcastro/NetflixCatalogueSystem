using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NetflixCatalogue
{
    public class Catalog
    {
        bool inCatalog = true;
        View view = new View();

        public List<Genre> genreList = new List<Genre>();

        public Genre all = new Genre("All");
        public Genre romance = new Genre("Romance");
        public Genre action = new Genre("Action");
        public Genre comedy = new Genre("Comedy");
        public Genre horror = new Genre("Horror");
        public Genre drama = new Genre("Drama");

        public Movie dieHard = new Movie(1,36, "Die Hard", "R","Action");
        Movie deadpool = new Movie(1, 48, "Deadpool", "R", "Action");
        Movie starWars = new Movie(2, 16, "Star Wars: The Force Awakens", "PG-13","Action");
        public Movie zoolander2 = new Movie(1,42, "Zoolander 2", "PG-13", "Comedy");
        Movie carol = new Movie(1, 58, "Carol", "R", "Drama");



        Show breakingBad = new Show("Breaking Bad", "TV-MA", "Drama");
        Show houseOfCards = new Show("House of Cards", "TV-MA", "Drama");
        Show orangeIsTheNewBlack = new Show("Orange Is the New Black", "TV-MA", "Drama");
        Show narcos = new Show("Narcos", "TV-MA", "Comedy");
        Show fullerHouse = new Show("Fuller House","TV-G", "Comedy");


        public Catalog()
        {
            genreList.Add(all);
            genreList.Add(romance);
            genreList.Add(action);
            genreList.Add(comedy);
            genreList.Add(horror);
            genreList.Add(drama);
                   
        }
        

        public void addTiitleToAll()
        {
            all += dieHard;
            all += breakingBad;
        }

        public void addTitleToGenre(Title title, Genre genre)
        {
            genre += title;
        }


        public void getCatelog()
        {
            while (inCatalog)
            {
                Console.WriteLine("NETFLIX CATALOG");
                Console.WriteLine("View [v] Add [a]");

                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                getKeyPressed(keyPressed);
                Console.WriteLine();
            }

        }


        public void getGenreMenu()
        {
            for( int genre = 0; genre < genreList.Count; genre++)
            {
                Console.WriteLine("[{0}] {1}", genre+1 ,genreList[genre].genreType);
            }
            Console.WriteLine();
        }

        public void getKeyPressed(ConsoleKeyInfo keyPressed)
        {
            if (keyPressed.KeyChar.Equals('v'))
            {
                getGenreMenu();

                keyPressed = Console.ReadKey(true);

                selectGenreInMenu(keyPressed);
            }
            else if (keyPressed.KeyChar.Equals('a'))
            {
                getAddMenu();



            }

        }

        public void selectGenreInMenu(ConsoleKeyInfo keyPressed)
        {
            try
            {
                int numPressed = int.Parse(keyPressed.KeyChar.ToString()) - 1;
                view.printOutGenresAndTitles(genreList[numPressed]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Entry");
            }
           

        }

        public void selectGenreInMenuToGetShow(ConsoleKeyInfo keyPressed)
        {
            try
            {
                int numPressed = int.Parse(keyPressed.KeyChar.ToString()) - 1;
                getListOfShows(genreList[numPressed]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Entry");
            }
           

        }

        public void getAddMenu()
        {
            Console.WriteLine("What do you want to add?");
            string[] thingsToAdd = { "Genre", "Show", "Movie", "Episode to Show" };

            for( int i = 0; i < thingsToAdd.Length; i++)
            {
                Console.WriteLine("[{0}] Add {1}", i+1, thingsToAdd[i]);
            }

            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            selectOptionInAddMenu(keyPressed);
        }

        public void selectOptionInAddMenu(ConsoleKeyInfo keyPressed)
        {
            if (keyPressed.KeyChar.Equals('1'))
            {
                //genre
                addNewGenre();
            }
            else if (keyPressed.KeyChar.Equals('2'))
            {
                //show
                addNewShow();
            }
            else if (keyPressed.KeyChar.Equals('3'))
            {
                //movie
                addNewMovie();
            }
            else if (keyPressed.KeyChar.Equals('4'))
            {
                //episode to show
                getEpisodesToShowMenu();
            }
          
        }

        public void addNewGenre()
        {
            Console.WriteLine("What is the name of the new genre?");
            Genre nameOfGenre = new Genre(Console.ReadLine());

            genreList.Add(nameOfGenre);
        }

        public void addNewShow()
        {
            Console.WriteLine("What is the name of the new show?");
            string showName = Console.ReadLine();

            Console.WriteLine("What is the rating for this show?");
            string rating = Console.ReadLine();

            Console.WriteLine("What is the genre for this show?");
            string genreType = Console.ReadLine();

            Show newShow = new Show(showName, rating, genreType);

            all += newShow;

            for ( int i = 0; i < genreList.Count; i++)
            {
                if (genreList[i].genreType.Equals(genreType))
                {
                    genreList[i] += newShow;
                }
            }
            
        }

        public void addNewMovie()
        {
            Console.WriteLine("What is the name of the new Movie?");
            string movieName = Console.ReadLine();

            Console.WriteLine("What is the rating for this Movie?");
            string rating = Console.ReadLine();

            Console.WriteLine("What is the genre for this Movie?");
            string genreType = Console.ReadLine();

            Console.WriteLine("How many hours is this movie?");
            int movieHours = int.Parse(Console.ReadLine());

            Console.WriteLine("How many minutes?");
            int movieMinutes = int.Parse(Console.ReadLine());

            Movie newMovie = new Movie(movieHours, movieMinutes, movieName, rating, genreType);
            all += newMovie;

            for (int i = 0; i < genreList.Count; i++)
            {
                if (genreList[i].genreType.Equals(genreType))
                {
                    genreList[i] += newMovie;
                }
            }

        }

        public void getEpisodesToShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select option from menu to find show:");
            getGenreMenu();
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            selectGenreInMenuToGetShow(keyPressed);
           

        }

        public void getListOfShows(Genre genre)
        {
            Console.WriteLine("Available shows in {0}:", genre.genreType);
            for(int i = 0; i < genre.titleList.Count; i++)
            {
                Console.WriteLine("[{0}] {1}", i+1, genre.titleList[i].name);
            }
            Console.WriteLine();

            selectShowToAddEpisode(genre);
        }

        public void selectShowToAddEpisode(Genre genre)
        {
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);

            Console.WriteLine("You pressed {0}", keyPressed.KeyChar);

            int numShow = int.Parse(keyPressed.KeyChar.ToString()) - 1;
            Console.WriteLine(genre.titleList[numShow]);
            Console.WriteLine("Do you want to add [a] or view [v] episode?");

        }


        public void addEpisodesToShow(Genre genre, int numShow)
        {
            ConsoleKeyInfo keypressed = Console.ReadKey();

            if (keypressed.KeyChar.Equals('a'))
            {
                //
            }
        }
    }
}
