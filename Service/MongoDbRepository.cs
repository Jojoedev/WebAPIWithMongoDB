using _WebAPIMongoDB.Interface;
using _WebAPIMongoDB.Models;
using MongoDB.Driver;

namespace _WebAPIMongoDB.Data
{
    public class MongoDbRepository : IProductInterface
    {
        private readonly IMongoCollection<Product> _product;

        public MongoDbRepository(IProductSettings productSettings, IMongoClient mongoClient)
        {
            
            var database = mongoClient.GetDatabase(productSettings.DatabaseName);
             _product = database.GetCollection<Product>(productSettings.ProductCollectionName);

        }

        public Product Create(Product product)
        {
            _product.InsertOne(product);
            return product;
        }

        public void Delete(int id)
        {
            _product.DeleteOne(x => x.Id == id);
           
        }

        public IEnumerable<Product> GetAll()
        {
          var products =  _product.Find(product => true).ToList();
            return products;    
        }

        public Product GetById(int id)
        {
            var product = _product.Find(x => x.Id == id).FirstOrDefault();
            return product;
        }

        public void Update(int id, Product product)
        {
            var updateProduct = _product.ReplaceOne(x => x.Id == id, product);

        }
    }
}
