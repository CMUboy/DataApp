using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataApp.Models
{
    public class EFDataRepository : IDataRepository
    {
        private readonly EFDatabaseContext context;

        public EFDataRepository(EFDatabaseContext context)
        {
            this.context = context;
        }

        public Product GetProduct(long id)
        {
            Console.WriteLine("GetProduct: " + id);
            return new Product();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            Console.WriteLine("GetAllProducts");
            return context.Products;
        }

        public void CreateProduct(Product newProduct)
        {
            Console.WriteLine("CreateProduct: "
                              + JsonConvert.SerializeObject(newProduct));
        }

        public void UpdateProduct(Product changedProduct)
        {
            Console.WriteLine("UpdateProduct : "
                              + JsonConvert.SerializeObject(changedProduct));
        }

        public void DeleteProduct(long id)
        {
            Console.WriteLine("DeleteProduct: " + id);
        }
    }
}
