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
    public class CatalogTests
    {
        [TestMethod()]
        public void addTitleToGenreTest()
        {
            //Arrange
            Catalog catalog = new Catalog();
            Genre generic = new Genre("generic");
            Show show = new Show("newShow", 5, "generic");

            //Act
            catalog.genreList.Add(generic);
            catalog.addTitleToGenre(show, generic);

            //Assert
            Assert.AreSame(catalog.genreList[6], generic);
        }


        [TestMethod()]
        public void addTitleToGenreTestNotTheSameGenre()
        {
            //Arrange
            Catalog catalog = new Catalog();

            Genre generic = new Genre("generic");
            Genre different = new Genre("different");

            Show show = new Show("newShow", 5, "generic");

            //Act
            catalog.genreList.Add(generic);
            catalog.addTitleToGenre(show, generic);

            //Assert
            Assert.AreNotSame(catalog.genreList[6], different);
        }

        [TestMethod()]
        public void addTiitleToAllTest()
        {
            //Arrange
            Catalog catalog = new Catalog();
            int titlesInCatalogAtStart = 11;

            //Act
            catalog.addTiitleToAll();

            //Assert
            Assert.AreEqual(titlesInCatalogAtStart, catalog.all.titleList.Count);

        }

        [TestMethod()]
        public void checkIfGenreExistTest()
        {
            //Arrange
            Catalog catalog = new Catalog();
            Genre newGenre = new Genre("Comedy");
            //Act

            bool alreadyCreated = catalog.checkIfGenreExist(newGenre.genreType);

            //Assert
            Assert.IsTrue(alreadyCreated);

        }

        [TestMethod()]
        public void genreDoesNotExitCreateTest()
        {
            //Arrange
            Catalog catalog = new Catalog();
            Genre doesntExist = new Genre("Dosen't Exist");

            //Act
            bool alreadyCreated = catalog.checkIfGenreExist(doesntExist.genreType);
            catalog.genreDoesNotExitCreate(alreadyCreated, doesntExist.genreType);

            //Assert
            Assert.AreEqual(doesntExist.genreType, catalog.genreList[6].genreType);

        }
    }
}