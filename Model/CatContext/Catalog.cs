namespace Model.CatalogCtx
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}