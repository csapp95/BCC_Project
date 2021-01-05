using BCC_MVC.Controllers;
using BCC_MVC.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCC_UnitTests.Controller
{
    [TestClass]
    public class MovieListingControllerTests
    {
        private MovieListingController _controller;
        private IMovieService _movieServiceSub;
        
        [TestInitialize]
        public void SetUp()
        {
            _movieServiceSub = Substitute.For<IMovieService>();
            _controller = new MovieListingController(_movieServiceSub);
        }

        
    }
}
