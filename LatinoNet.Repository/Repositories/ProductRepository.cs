using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly LatinoNetContext Context;
        public ProductRepository(LatinoNetContext context)
        {
            Context=context;
        }
        public void CreateProduct(Product product)
        {
            Context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return Context.Products;
        }

        public Product GetProduct(int productId)
        {
           return Context.Products.Find(productId);
        }
    }
}
