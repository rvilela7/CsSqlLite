
namespace Model.CatalogCtx
{
    using System.Collections.Generic;
    public class Catalog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Book> Books { get; } = new List<Book>();
    }
}