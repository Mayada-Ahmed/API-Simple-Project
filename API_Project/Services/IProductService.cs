using API_Project.Models;
using System.Collections.Generic;

namespace API_Project.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Insert(Product product);
        void Remove(int id);
        void Update(Product product);
    }
}