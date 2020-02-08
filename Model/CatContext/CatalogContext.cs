using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model.Catalog
{
    public class CatalogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");
    }

    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public List<Post> Catalog { get; } = new List<Catalog>();
    }

    public class Catalog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}