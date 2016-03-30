using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilize the null operators we covered in class
            //Utilize appropriate access modifiers
            //Create at least 10 unit tests
            //Show the program in use.Essentially, there needs to be data, run the program,
            //      and print to the console to show that the program works.

            Catalog catalog = new Catalog();
            View view = new View();

            catalog.addTiitleToAll();

            view.printOutGenresAndTitles(catalog.all);
            Console.ReadLine();

        }
    }
}
