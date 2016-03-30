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
            Title title = new Title("movie", "PG");

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
    }
}