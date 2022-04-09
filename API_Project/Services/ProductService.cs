using API_Project.Data;
using API_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace API_Project.Services
{
    public class ProductService : IProductService
    {
        private readonly Context context;

        public ProductService(Context context)
        {
            this.context = context;
        }

        public List<Product> GetAll()
        {

            return context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return context.Products.FirstOrDefault(p => p.Id == id);
        }
        public void Insert(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == id);
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public void Update(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }
    }
}
