using System.Collections.Generic;

namespace Model.CatalogCtx
{
    public class Book
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public int CatalogId { get; set; }
        public Catalog Catalog { get; set; }
    }   
}