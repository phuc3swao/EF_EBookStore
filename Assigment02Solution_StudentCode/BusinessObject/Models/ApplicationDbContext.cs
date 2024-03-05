using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            //IConfigurationRoot configuration = builder.Build();
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("eBookStore"));

            optionsBuilder.UseSqlServer("Server=localhost;Database=AS01_PRN231;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.Author_id, ba.Book_id });
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookAuthor> BookAuthor { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
