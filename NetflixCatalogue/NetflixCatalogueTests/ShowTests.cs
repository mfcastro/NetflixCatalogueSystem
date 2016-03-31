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
        public void createEpisodeTest()
        {
            //Arrange
            List<Episode> episodes = new List<Episode>();
            Show show = new Show("One", "R");
            string episodetitle = "OneTitle";
            string rating = "R";

            //Act
            show.createEpisode(episodetitle, rating);
            //Assert
            Assert.AreSame(episodetitle, show.episodes[0].episodeName);
            Assert.AreSame(rating, show.episodes[0].rating);
           
        }
    }
}