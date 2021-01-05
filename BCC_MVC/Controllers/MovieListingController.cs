using BCC_MVC.Models;
using BCC_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCC_MVC.Controllers
{
    public class MovieListingController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieListingController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        /// <summary>
        /// Returns the MovieListings view with the most recent Movie Listing collection.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult MovieListings()
        {
            var listings = new MovieListings(_movieService.GetAllMovies());
            return View("MovieListings", listings);
        }

        /// <summary>
        /// Directs to a new page to add a new Movie Listing.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult NewListingPage()
        {
            return PartialView("_NewListingPage");
        }

        /// <summary>
        /// Endpoint that will add the new listing if valid and redirect to the MovieListings view.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NewListing(Movie movie)
        {
            if (movie != null && MovieListingIsValid(movie))
            {
                _movieService.SaveOrUpdate(movie);
            }
            
            return MovieListings();
        }

        /// <summary>
        /// Directs to the MovieInfo view displaying more specifics of the movie.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult MovieInfo(int id)
        {
            var movie = _movieService.GetMovie(id);

            return View("MovieInfo", movie);
        }

        /// <summary>
        /// Determines if the given movie is valid.
        /// Only valid if Title, Description, and ThumbnailRef are not null.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        private bool MovieListingIsValid(Movie movie)
        {
            return (movie.Title != null || movie.Description != null || movie.ThumbnailRef != null);
        }
    }
}
