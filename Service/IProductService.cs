using _WebAPIMongoDB.Interface;
using _WebAPIMongoDB.Models;

namespace _WebAPIMongoDB.Service
{
    public class IProductService //This is supposed to implement IProductInterface
    {
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return Data.ProductDB.products;
        }
    }
}
