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
    public class TitleTests
    {
        [TestMethod()]
        public void TitleTest()
        {
            Title title = new Title("movie", 4, "Generic");

            Assert.IsNotNull(title.name);
            Assert.IsNotNull(title.rating);
        }

        [TestMethod()]
        public void TitleTestIsNull()
        {
            Title title = new Title();

            Assert.IsNull(title.name);
            Assert.IsNull(title.rating);
        }

        public void TitleTestCorrectValues()
        {
            Title title = new Title("movie", 4, "Generic");
            string name = "movie";
            string rating = "PG";
            string genreType = "Generic";

            Assert.AreEqual(name, title.name);
            Assert.AreEqual(rating, title, rating);
            Assert.AreEqual(genreType, title.genreType);

        }
    }
}