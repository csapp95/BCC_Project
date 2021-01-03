using BCC_MVC.Data;
using BCC_MVC.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BCC_MVC.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieListingDbContext _movieListingDbContext;
        private readonly ILogger _logger;

        public MovieService(ILogger<MovieService> logger, MovieListingDbContext movieListingDbContext)
        {
            _movieListingDbContext = movieListingDbContext;
            _logger = logger;
        }

        public Movie GetMovie(int id)
        {
            return _movieListingDbContext.Movies.Where(x => x.Id == id).FirstOrDefault();
        }

        public Movie GetMovie(string title) 
        {
            return _movieListingDbContext.Movies.Where(x => x.Title == title).FirstOrDefault();
        }

        public bool SaveOrUpdate(Movie movie)
        {
            return false;
        }
    }
}
