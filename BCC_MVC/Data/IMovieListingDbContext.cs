using BCC_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCC_MVC.Data
{
    public interface IMovieListingDbContext
    {
        public Movie GetMovie(int id);
        public Movie GetMovie(string title);
        public void Add(Movie movie);
        public void Update(Movie movie);
        public List<Movie> GetAllMovies();
    }
}
