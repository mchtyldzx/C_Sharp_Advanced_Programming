using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MovieCollection.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MovieContext>>()))
        {
            // Check if there are any movies in the database
            if (context.Movies.Any())
            {
                return;   // Database has been seeded
            }

            context.Movies.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "8"
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-3-24"),
                    Genre = "Crime/Drama",
                    Price = 8.99M,
                    Rating = "10"
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Genre = "Action",
                    Price = 9.99M,
                    Rating = "9"
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Return of the King",
                    ReleaseDate = DateTime.Parse("2003-12-17"),
                    Genre = "Fantasy",
                    Price = 10.99M,
                    Rating = "9"
                },
                new Movie
                {
                    Title = "Forrest Gump",
                    ReleaseDate = DateTime.Parse("1994-7-6"),
                    Genre = "Drama/Comedy",
                    Price = 6.99M,
                    Rating = "5"
                }
            );
            context.SaveChanges();
        }
    }
} 