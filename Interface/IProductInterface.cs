using _WebAPIMongoDB.Models;

namespace _WebAPIMongoDB.Interface
{
    public interface IProductInterface
    {
        IEnumerable<Product> GetAll();

        public void Create(Product product);


    }

   
}
