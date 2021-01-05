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
        private readonly IMovieListingDbContext _movieListingDbContext;
        private readonly ILogger _logger;

        public MovieService(ILogger<IMovieService> logger, MovieListingDbContext movieListingDbContext)
        {
            _movieListingDbContext = movieListingDbContext;
            _logger = logger;
        }

        /// <summary>
        /// Gets a movie by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Movie GetMovie(int id)
        {
            return _movieListingDbContext.GetMovie(id);
        }

        /// <summary>
        /// Gets a movie by Title.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public Movie GetMovie(string title) 
        {
            return _movieListingDbContext.GetMovie(title);
        }
        
        /// <summary>
        /// Returns current Movie collection.
        /// </summary>
        /// <returns></returns>
        public List<Movie> GetAllMovies()
        {
            return _movieListingDbContext.GetAllMovies();
        }

        /// <summary>
        /// Updates the given movie entity if contained in the current context, else adds the new movie.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public bool SaveOrUpdate(Movie movie)
        {
            var hasMovie = _movieListingDbContext.GetMovie(movie.Id) != null;
            if (hasMovie)
            {
                _movieListingDbContext.Update(movie);
            }
            else
            {
                _movieListingDbContext.Add(movie);
            }
            MovieDataGenerator.ExportData(_movieListingDbContext.GetAllMovies());
            return true;
        }
    }
}
