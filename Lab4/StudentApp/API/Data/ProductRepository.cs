using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Product product)
        {
            this.context.Add(product);
            this.context.SaveChanges();
        }

        public void Update(Product product)
        {
            this.context.Update(product);
            this.context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return this.context.Product.ToList();
        }

        public Product GetById(int id)
        {
            return this.context.Product.Find(id);
        }

        public void Remove(Product product)
        {
            this.context.Remove(product);
            this.context.SaveChanges();
        }


    }
}
