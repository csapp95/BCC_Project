using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCC_MVC.Models
{
    /// <summary>
    /// Model for displaying the collection of Movie Listings
    /// on the MovieListings page
    /// </summary>
    public class MovieListings
    {
        public List<Movie> Listings { get; set; }

        public MovieListings(List<Movie> movieListings)
        {
            Listings = movieListings;
        }
    }
}
