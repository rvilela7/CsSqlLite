using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Model.CatalogCtx
{
    public class CatalogContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Catalog> Catalog { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Try In appsettings.json
            options.UseSqlite("Data Source=Catalog.db");
        }
    }
}