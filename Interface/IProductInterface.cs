using _WebAPIMongoDB.Models;

namespace _WebAPIMongoDB.Interface
{
    public interface IProductInterface
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        Product Create(Product product);
        void Update(int id, Product product);
        void Delete(int id);




    }

   
}
