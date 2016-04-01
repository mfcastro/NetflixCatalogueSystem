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
    public class ShowTests
    {
        [TestMethod()]
        public void getAggregateRatingTest()
        {
            //Arrange
            Show show = new Show("The Best Show Ever", 4, "Comedy" );
            Episode one = new Episode("Pilot Episode", 4.5);
            Episode Two = new Episode("Here we are again", 5);
            Episode three = new Episode("Last episode for now", 3);

            double newRating = (4.5 + 5 + 3) / 3;
            //Act
            show += one;
            show += Two;
            show += three;
            show.getAggregateRating(show);

            //Assert
            Assert.AreEqual(newRating, show.rating);
         
        }

        [TestMethod()]
        public void getAggregateRatingTestMissingOneEpisode()
        {
            //Arrange
            Show show = new Show("The Best Show Ever", 4, "Comedy");
            Episode one = new Episode("Pilot Episode", 4.5);
            Episode Two = new Episode("Here we are again", 5);
            Episode three = new Episode("Last episode for now", 3);

            double newRating = (4.5 + 5 + 3) / 3;
            //Act
            show += one;
            show += Two;
            show.getAggregateRating(show);

            //Assert
            Assert.AreNotEqual(newRating, show.rating);

        }

        [TestMethod()]
        public void getAggregateRatingIsNull()
        {
            //Arrange
            Show show = new Show("The Best Show Ever", 4, "Comedy");
            Episode one = new Episode("Pilot Episode", 4.5);
            Episode Two = new Episode("Here we are again", 5);
            Episode three = new Episode("Last episode for now", 3);

            double ? newRating = null;
            //Act
            show.rating = null;

            //Assert
            Assert.IsNull(newRating, show.rating.ToString());

        }


    }
}