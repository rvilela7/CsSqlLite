using System;
using Model.CatalogCtx;
using System.Linq;

namespace Model
{
    public class CatalogModel
    {
        private readonly CatalogContext _catalogContext;

        public CatalogModel(CatalogContext catalogContext)
        {
            this._catalogContext = catalogContext;
        }

        public void CreateBook()
        {
            if (_catalogContext.Catalog.Any())
                return;

            var myCatalog = new Catalog() { Title = "Catalog Demo" };
            _catalogContext.Catalog.Add(myCatalog);

            _catalogContext.Book.Add(new Book()
            {
                Name = "Book Demo",
                Url = "Books4All",
                CatalogId = myCatalog.Id,
            });

            _catalogContext.SaveChangesAsync();
        }
    }
}
