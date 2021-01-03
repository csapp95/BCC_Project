using BCC_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCC_MVC.Services
{
    interface IMovieService
    {
        public Movie GetMovie(int id);
        public Movie GetMovie(string title);

        public bool SaveOrUpdate(Movie movie);
    }
}
