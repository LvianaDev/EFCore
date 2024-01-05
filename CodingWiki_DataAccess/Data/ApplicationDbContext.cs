using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localDb)\\MSSQLLocalDB;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title= "Spider without Duty", ISBN = "123B12", Price = 10.99m },
                new Book { BookId = 2, Title= "Fortune of time", ISBN = "123B12", Price = 11.99m }
                );

            var bookList = new Book[]
            {
                new Book { BookId = 3, Title= "Fortune of time", ISBN = "77765", Price = 15.99m },
                new Book { BookId = 4, Title= "Cookie Jar", ISBN = "CC54B4", Price = 14.99m },
                new Book { BookId = 5, Title= "Cloudy Forest", ISBN = "123C12", Price = 13.99m }

            };
            modelBuilder.Entity<Book>().HasData(bookList);
        }

    }
}
