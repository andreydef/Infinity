using System;
using Microsoft.EntityFrameworkCore;
using Infinity_app.Models.Main_models;

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
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Resume> Resume { get; set; }
        public DbSet<Work_Experience> Work_Experience { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Main_info> Main_info { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Info_jobs> Info_jobs { get; set; }
        public DbSet<Contact_me> Contact_me { get; set; }
        public DbSet<Contact_info> Contact_info { get; set; }
    }
}