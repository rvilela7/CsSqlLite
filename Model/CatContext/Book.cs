using System.Collections.Generic;

namespace Model.CatalogCtx
{
    public class Book
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public List<Catalog> Catalogs { get; } = new List<Catalog>();
    }
}