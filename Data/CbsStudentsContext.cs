using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cbsStudents.Models.Entities;
using cbsStudents.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CbsStudents.Data
{
    public class CbsStudentsContext : IdentityDbContext
    {
        public CbsStudentsContext(DbContextOptions<CbsStudentsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.UsersSeed(builder);
            this.SeedPosts(builder);
            this.SeedComments(builder);
            this.SeedEvents(builder);
            this.SeedEventComments(builder);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<cbsStudents.Models.Entities.Comment> Comment { get; set; }
        public DbSet<cbsStudents.Models.Entities.EventComment> EventComment { get; set; }

        private void UsersSeed(ModelBuilder builder)
        {
            var user1 = new IdentityUser
            {
                Id = "1",
                Email = "chrk@kea.dk",
                EmailConfirmed = true,
                UserName = "chrk@kea.dk",
            };

            var user2 = new IdentityUser
            {
                Id = "2",
                Email = "test@kea.dk",
                EmailConfirmed = true,
                UserName = "test@kea.dk",
            };

            PasswordHasher<IdentityUser> passHash = new PasswordHasher<IdentityUser>();
            user1.PasswordHash = passHash.HashPassword(user1, "aA123456!");
            user2.PasswordHash = passHash.HashPassword(user2, "aA123456!");

            builder.Entity<IdentityUser>().HasData(
                user1, user2
            );
        }
        private void SeedPosts(ModelBuilder builder)
        {
            builder.Entity<Post>().HasData(
                new Post() { Id = 1, Created = DateTime.Now, Text = "This is post 1", Title = "Post no 1", Status = PostStatus.DRAFT },
                new Post() { Id = 2, Created = DateTime.Now, Text = "This is post 2", Title = "Post no 2", Status = PostStatus.DRAFT },
                new Post() { Id = 3, Created = DateTime.Now, Text = "This is post 3", Title = "Post no 3", Status = PostStatus.DRAFT }
            );
        }

        private void SeedEvents(ModelBuilder builder)
        {
            builder.Entity<Event>().HasData(
                new Event() { EventId = 1, EventTitle = "Event no 1", EventText = "This is Event 1", Location = "CBS", StartDate = DateTime.Now, EndDate = DateTime.Now, PhotoURL = "Event no 1", Responsible = "Event no 1", Collaboration = "Event no 1", ReservedRoom = "Event no 1", Status = PostStatus.DRAFT, UserId= "1" },
                new Event() { EventId = 2, EventTitle = "Event no 2", EventText = "Event no 2", Location = "KEA", StartDate = DateTime.Now, EndDate = DateTime.Now, PhotoURL = "Event no 2", Responsible = "Event no 2", Collaboration = "Event no 2", ReservedRoom = "Event no 2", Status = PostStatus.DRAFT, UserId= "1" },                
                new Event() { EventId = 3, EventTitle = "Event no 3", EventText = "Event no 3", Location = "Home", StartDate = DateTime.Now, EndDate = DateTime.Now, PhotoURL = "Event no 3", Responsible = "Event no 3", Collaboration = "Event no 3", ReservedRoom = "Event no 3", Status = PostStatus.DRAFT, UserId= "1" }
            );
        }

        private void SeedComments(ModelBuilder builder)
        {
            builder.Entity<Comment>().HasData(
                new Comment() { CommentId = 1, Text = "Hello", TimeStamp = DateTime.Now, PostId = 1, UserId = "1" },
                new Comment() { CommentId = 2, Text = "Hello again", TimeStamp = DateTime.Now, PostId = 1, UserId = "2" },
                new Comment() { CommentId = 3, Text = "Hi", TimeStamp = DateTime.Now, PostId = 2, UserId = "1" },
                new Comment() { CommentId = 4, Text = "Bye", TimeStamp = DateTime.Now, PostId = 4, UserId = "1" }
            );
        }

        private void SeedEventComments(ModelBuilder builder)
        {
            builder.Entity<EventComment>().HasData(
                new EventComment() { EventCommentId = 1, Text = "Hello", TimeStamp = DateTime.Now, EventId = 1, UserId = "1" },
                new EventComment() { EventCommentId = 2, Text = "Hello again", TimeStamp = DateTime.Now, EventId = 1, UserId = "2" },
                new EventComment() { EventCommentId = 3, Text = "Hi", TimeStamp = DateTime.Now, EventId = 2, UserId = "1" },
                new EventComment() { EventCommentId = 4, Text = "Bye", TimeStamp = DateTime.Now, EventId = 3, UserId = "1" }
            );
        } 
    }
}