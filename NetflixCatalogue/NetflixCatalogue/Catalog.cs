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

        public Movie dieHard = new Movie(1,36, "Die Hard", 5,"Action");
        Movie deadpool = new Movie(1, 48, "Deadpool", 5, "Action");
        Movie starWars = new Movie(2, 16, "Star Wars: The Force Awakens", 5,"Action");
        public Movie zoolander2 = new Movie(1,42, "Zoolander 2", 5, "Comedy");
        Movie carol = new Movie(1, 58, "Carol", 3.5, "Drama");



        Show breakingBad = new Show("Breaking Bad", 4.8, "Drama");
        Show houseOfCards = new Show("House of Cards", 5, "Drama");
        Show orangeIsTheNewBlack = new Show("Orange Is the New Black", 3.75, "Drama");
        Show narcos = new Show("Narcos", 4, "Comedy");
        Show fullerHouse = new Show("Fuller House",4.25, "Comedy");

        Episode one = new Episode("Episode 1", 4);
        Episode two = new Episode("Episodee 2", 4.25);
        Episode three = new Episode("Episode 3", 4.5);

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
            all += dieHard;
            all += deadpool;
            all += starWars;
            all += zoolander2;
            all += carol;
            all += houseOfCards;
            all += orangeIsTheNewBlack;
            all += narcos;
            all += fullerHouse;
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

                string keyPressed = Console.ReadLine();


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

        public void getKeyPressed(string keyPressed)
        {
            if (keyPressed.Equals("v"))
            {
                getGenreMenu();

                keyPressed = Console.ReadLine();

                selectGenreInMenu(keyPressed);
            }
            else if (keyPressed.Equals("a"))
            {
                getAddMenu();



            }

        }

        public void selectGenreInMenu(string keyPressed)
        {
            try
            {
                int numPressed = int.Parse(keyPressed.ToString()) - 1;
                view.printOutGenresAndTitles(genreList[numPressed]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Entry");
            }
           

        }

        public void selectGenreInMenuToGetShow(string keyPressed)
        {
            try
            {
                int numPressed = int.Parse(keyPressed.ToString()) - 1;
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

      
            string keyPressed = Console.ReadLine();
            selectOptionInAddMenu(keyPressed);
        }

        public void selectOptionInAddMenu(string keyPressed)
        {
            if (keyPressed.Equals("1"))
            {
              
                addNewGenre();
            }
            else if (keyPressed.Equals("2"))
            {
             
                addNewShow();
            }
            else if (keyPressed.Equals("3"))
            {
             
                addNewMovie();
            }
            else if (keyPressed.Equals("4"))
            {
            
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
            double rating = Double.Parse(Console.ReadLine());

            Console.WriteLine("What is the genre for this show?");
            string genreType = Console.ReadLine();
            bool exist = checkIfGenreExist(genreType);
            genreDoesNotExitCreate(exist, genreType);

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
            double rating = Double.Parse(Console.ReadLine());

            Console.WriteLine("What is the genre for this Movie?");
            string genreType = Console.ReadLine();
            bool exist =checkIfGenreExist(genreType);
            genreDoesNotExitCreate(exist, genreType);

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
            string keyPressed = Console.ReadLine();
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
            string keyPressed = Console.ReadLine();

            
            int numShow = int.Parse(keyPressed.ToString()) - 1;
            Console.WriteLine(genre.titleList[numShow]);
            Console.WriteLine("Do you want to add [a] or view [v] episode?");
            addEpisodesToShow(genre, numShow);

        }


        public void addEpisodesToShow(Genre genre, int numShow)
        {

            string keyPressed = Console.ReadLine();

            if (keyPressed.Equals("a"))
            {
                
                Console.WriteLine(genre.titleList[numShow].name);
            }
        }


        public bool checkIfGenreExist(String genreType)
        {
            bool alreadyExists = false;

            for(int i = 0; i < genreList.Count; i++)
            {
                if (genreType.Equals(genreList[i].genreType))
                {
                    alreadyExists = true;
                    return alreadyExists;
                }
            }
            return alreadyExists;
        }

        public void genreDoesNotExitCreate(bool exists, string genreType)
        {
            if (exists == false)
            {
                Genre newGenre = new Genre(genreType);
                genreList.Add(newGenre);
            }
        }
    }
}
