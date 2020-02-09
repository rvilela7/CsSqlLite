using System;

namespace Cli
{
    using Model;
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CatalogModel catalogModel = new CatalogModel();

            catalogModel.CreateBook();
        }
    }
}
