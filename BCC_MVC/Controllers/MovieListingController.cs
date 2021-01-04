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

        [HttpGet]
        public IActionResult MovieListings()
        {
            var listings = new MovieListings(_movieService.GetAllMovies());
            return View("MovieListings", listings);
        }

        [HttpGet]
        public IActionResult NewListingPage()
        {
            return PartialView("_NewListingPage");
        }

        [HttpPost]
        public IActionResult NewListing(Movie movie)
        {
            if (movie != null)
            {
                _movieService.SaveOrUpdate(movie);
            }
            
            return MovieListings();
        }
    }
}
