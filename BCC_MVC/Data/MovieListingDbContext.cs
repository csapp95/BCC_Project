using BCC_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCC_MVC.Data
{
    public class MovieListingDbContext : DbContext
    {
        public MovieListingDbContext(DbContextOptions<MovieListingDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
