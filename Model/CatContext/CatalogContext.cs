using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Model.Catalog
{
    public class CatalogContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Catalog> Catalog { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Catalog.db");
    }

    public class Book
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public List<Catalog> Catalogs { get; } = new List<Catalog>();
    }

    public class Catalog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}