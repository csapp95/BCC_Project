using BCC_MVC.Data;
using BCC_MVC.Models;
using BCC_MVC.Services;
using Microsoft.Extensions.Logging;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCC_UnitTests
{
    [TestFixture]
    public class MovieServiceTests
    {
        private IMovieListingDbContext _contextSub;
        private IMovieService _movieService;
        private ILogger<IMovieService> _loggerSub;

        [SetUp]
        public void SetUp()
        {
            _loggerSub = Substitute.For<ILogger<IMovieService>>();
            _contextSub = Substitute.For<IMovieListingDbContext>();
            _movieService = new MovieService(_loggerSub, (MovieListingDbContext)_contextSub);
        }

        [Test]
        public void MovieService_SaveOrUpdate_AddCallTest()
        {
            var movie = new Movie();

            _movieService.SaveOrUpdate(movie);

            var calls = _contextSub.ReceivedCalls();
            var method = calls.Select(x=>x.GetMethodInfo().Name == "Add");
            Assert.IsNotNull(method);
        }

        [Test]
        public void MovieService_SaveOrUpdate_UpdateCall_Test()
        {
            var movie = new Movie();
            _contextSub.GetMovie(0).ReturnsForAnyArgs(new Movie());
            _movieService.SaveOrUpdate(movie);

            var calls = _contextSub.ReceivedCalls();
            var method = calls.Select(x => x.GetMethodInfo().Name == "Update");
            Assert.IsNotNull(method);
        }

    }
}
