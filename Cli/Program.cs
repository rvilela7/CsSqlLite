using System;

namespace Cli
{
    using Model;
    using Model.CatalogCtx;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CatalogModel catalogModel = new CatalogModel(new CatalogContext());
            catalogModel.CreateBook();
        }
    }
}
