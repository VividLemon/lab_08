﻿using Lab_06.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
namespace Lab_06.Models
{
    public static class Seeder
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            User admin = new User { Name = "Admin", Password = "Admin" };
            User user = new User { Name = "User", Password = "User" };
            context.Database.Migrate();
            if (!context.Users.Any())
            {
                context.Users.AddRange(admin, user);
                context.SaveChanges();
            }
            List<Genre> genres = new List<Genre>() { new Genre { Name = "Some genre", Description = "Some genre description" }, { new Genre { Name = "Some genre", Description = "222" } } };
            List<Genre> genres2 = new List<Genre>() { new Genre { Name = "Third", Description = "Descc" } };
            Video video = new Video { Name = "Video 1", Description = "Some video desc", User = admin, Genres = genres };
            Video video2 = new Video { Name = "Video 2", Description = "Some second video", User = admin, Genres = genres2 };
            if (!context.Videos.Any())
            {
                context.Videos.AddRange(video, video2);
                context.SaveChanges();
            }
            Genre genre = new Genre { Name = "first genre", Description = "First genre description" };
            Genre secondGenre = new Genre { Name = "Second genre", Description = "Second genre description" };
            if (!context.Genres.Any())
            {
                context.Genres.AddRange(genre, secondGenre);
                context.SaveChanges();
            }
            Comment comment = new Comment { Text = "Test comment 1", Video = video, User = admin };
            Comment comment2 = new Comment { Text = "Second test comment", User = user, Video = video };
            if (!context.Comments.Any())
            {
                context.Comments.AddRange(comment, comment2);
                context.SaveChanges();
            }
        }
    }
}
