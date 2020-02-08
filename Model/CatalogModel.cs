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

        public void CreateBook ()
        {
            if (!_catalogContext.Catalog.Any())
            {
                _catalogContext.Catalog.Add(new Catalog(){ Title = "Teste" });
            }

            _catalogContext.Book.Add(new Book(){Url="AAA" });
        }
    }
}
