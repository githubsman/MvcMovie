using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                    new Movie { Title = "Local Hero", ReleaseDate = DateTime.Parse("1985-2-12"), Genre = "Comedy", Rating = "PG-13", Price = 7.99M },
                    new Movie { Title = "Twelve Chairs, The", ReleaseDate = DateTime.Parse("1974-2-12"), Genre = "Comedy", Rating = "PG", Price = 5.80M },
                    new Movie { Title = "Seven Samurai, The", ReleaseDate = DateTime.Parse("1974-2-12"), Genre = "Drama", Rating = "PG-13", Price = 9.99M },
                    new Movie { Title = "Notorious", ReleaseDate = DateTime.Parse("1967-2-12"), Genre = "Drama", Rating = "PG", Price = 5.00M },
                    new Movie { Title = "Big Fish", ReleaseDate = DateTime.Parse("2018-2-12"), Genre = "Comedy", Rating = "PG", Price = 6.99M }
            );
            context.SaveChanges();
        }
    }
}