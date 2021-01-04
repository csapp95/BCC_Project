using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCC_MVC.Models
{
    public class MovieListings
    {
        public List<Movie> Listings { get; set; }

        public MovieListings(List<Movie> movieListings)
        {
            Listings = movieListings;
        }
    }
}
