using API.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public interface IProductRepository
    {
        void Create(Product product);
        IEnumerable<Product> GetAll();
        Product GetById(int Id);
        void Remove(Product Product);
        void Update(Product Product);
    }
}
