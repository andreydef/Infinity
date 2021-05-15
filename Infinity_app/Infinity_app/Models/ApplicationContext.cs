using Microsoft.EntityFrameworkCore;
using System;

namespace Infinity_app.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<About> About { get; set; }
        public DbSet<Contact_me> Contact_me { get; set; }
        public DbSet<Contact_info> Contact_info { get; set; }
        public DbSet<Links> Links { get; set; }
        public DbSet<Contacts> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>().HasData(new About[]
            {
                new About
                {
                    Id = 1,
                    Title = "ABOUT US",
                    Description = "is a creative digital agency based in Manila, Philippines. We are composed of creative designers and experienced developers."
                }
            });
            modelBuilder.Entity<Contact_me>().HasData(new Contact_me[]
            {
                new Contact_me
                {
                    Id = 1,
                    Title = "Get In Touch.",
                    Description = "Quisque velit nisi, pretium ut lacinia in, elementum id enim. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi."
                }
            });
            modelBuilder.Entity<Contact_info>().HasData(new Contact_info[]
            {
                new Contact_info
                {
                    Id = 1,
                    Title = "WHERE TO FIND ME",
                    Short_desc = "1600 Amphitheatre Parkway "
                },
                new Contact_info
                {
                    Id = 2,
                    Title = "EMAIL ME AT",
                    Short_desc = "someone@kardswebsite.com"
                },
                new Contact_info
                {
                    Id = 3,
                    Title = "CALL ME AT",
                    Short_desc = "Phone: (+63) 555 1212"
                }
            });
            modelBuilder.Entity<Links>().HasData(new Links[]
            {
                new Links
                {
                    Id = 1,
                    Link_facebook = "https://www.facebook.com/profile.php?id=100009036657512",
                    Link_github = "https://github.com/andreydef",
                    Link_twitter = "https://twitter.com/Andriy346",
                    Link_instagram = "https://www.instagram.com/_andriy_halelyuka_/"
                }
            });
            modelBuilder.Entity<Contacts>().HasData(new Contacts[]
            {
                new Contacts
                {
                    Id = 1,
                    Name = "test",
                    Email = "test@gmail.com",
                    Subject = "test",
                    Message = "test message"
                }
            });
        }
    }
}