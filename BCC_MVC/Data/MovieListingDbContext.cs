using BCC_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCC_MVC.Data
{
    public class MovieListingDbContext : DbContext, IMovieListingDbContext
    {
        public MovieListingDbContext(DbContextOptions<MovieListingDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public Movie GetMovie(int id)
        {
            return Movies.Where(x => x.Id == id).FirstOrDefault();
        }

        public Movie GetMovie(string title)
        {
            return Movies.Where(x => x.Title == title).FirstOrDefault();
        }

        public void Add(Movie movie)
        {
            Movies.Add(movie);
            this.SaveChanges();
        }

        public void Update(Movie movie)
        {
            Movies.Update(movie);
            this.SaveChanges();
        }

        public List<Movie> GetAllMovies()
        {
            return Movies.ToList();
        }
    }
}
