using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogue.Tests
{
    [TestClass()]
    public class MovieTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange
            Movie myMovie = new Movie(1, 54, "Movie", 5, "Generic");
            string myString = String.Format("Name of Show: {0}, Duration of Movie: {1}", myMovie.name, myMovie.duration);

            //Act
            string actual = myMovie.ToString();
            //Assert

            Assert.AreEqual(myString, actual);
        }

        [TestMethod()]
        public void ToStringTestNotEqual()
        {
            //Arrange
            Movie myMovie = new Movie(1, 54, "Movie", 5, "Generic");
            string name = "Movie";
            string duration = "4h 56mins";
            string myString = String.Format("Name of Show: {0}, Duration of Movie: {1}", name, duration);

            //Act
            string actual = myMovie.ToString();
            //Assert

            Assert.AreNotEqual(myString, actual);
        }

    }
}