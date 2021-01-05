using BCC_MVC.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCC_UnitTests.Models
{
    [TestFixture]
    public class MovieTests
    {
        private Movie _movie;

        [SetUp]
        public void SetUp()
        {
            _movie = new Movie();
        }

        [Test]
        public void Movie_Id_Test()
        {
            //Arrange
            int id = 72;

            //Act
            _movie.Id = id;

            //Assert
            Assert.AreEqual(_movie.Id, id);
        }

        [Test]
        public void Movie_Title_Test()
        {
            //Arrange
            string title = "Movie Title";

            //Act
            _movie.Title = title;

            //Assert
            Assert.AreEqual(_movie.Title, title);
        }

        [Test]
        public void Movie_Description_Test()
        {
            //Arrange
            string description = "Movie Description";

            //Act
            _movie.Description = description;

            //Assert
            Assert.AreEqual(_movie.Description, description);
        }

        [Test]
        public void Movie_ThumbnailRef_Test()
        {
            //Arrange
            string thumbnailRef = "Thumbnail References";

            //Act
            _movie.ThumbnailRef = thumbnailRef;

            //Assert
            Assert.AreEqual(_movie.ThumbnailRef, thumbnailRef);
        }
    }
}
