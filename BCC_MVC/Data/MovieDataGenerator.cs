using BCC_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BCC_MVC.Data
{
    public class MovieDataGenerator
    {

        public static void GenerateData(IServiceProvider serviceProvider)
        {

            List<Movie> movies = new List<Movie>();

            using (var fileStream = new StreamReader("Resources/MovieListingData.json"))
            {
                string json = fileStream.ReadToEnd();
                movies = JsonConvert.DeserializeObject<List<Movie>>(json);
            }
            using (var context = new MovieListingDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieListingDbContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                context.Movies.AddRange(movies);

                context.SaveChanges();
            }
        }

        public static void ExportData(List<Movie> movies)
        {
            
            using (var stream = new StreamWriter("Resources/MovieListingData.json"))
            {
                stream.WriteAsync(JsonConvert.SerializeObject(movies));
            }
        }
    }
}
