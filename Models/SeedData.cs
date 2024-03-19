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
                new Movie
                {
                    Name = "Harry",
                    Birthday = DateTime.Parse("1989-2-12"),
                    Relationship = "Business",
                    Gender = "M",
                    Number = "555 555 5555"
                },
                new Movie
                {
                    Name = "Sally ",
                    Birthday = DateTime.Parse("1984-3-13"),
                    Relationship = "Business",
                    Gender = "F",
                    Number = "555 555 5555"
                },
                new Movie
                {
                    Name = "Bob",
                    Birthday = DateTime.Parse("1986-2-23"),
                    Relationship = "Personal",
                    Gender = "M",
                    Number = "555 555 5555"
                },
                new Movie
                {
                    Name = "Rico",
                    Birthday = DateTime.Parse("1959-4-15"),
                    Relationship = "Personal",
                    Gender = "M",
                    Number = "555 555 5555"
                }
            );
            context.SaveChanges();
        }
    }
}
