using _WebAPIMongoDB.Interface;
using _WebAPIMongoDB.Models;
using MongoDB.Driver;

namespace _WebAPIMongoDB.Data
{
    public class MongoDbRepository : IProductInterface
    {

        private const string databaseName = "Product_MongoDB";
        private const string collectionName = "products";


        private readonly IMongoCollection<Product> productCollection;

        public MongoDbRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            productCollection = database.GetCollection<Product>(collectionName);

        }

        public void Create(Product product)
        {
            productCollection.InsertOne(product);
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
