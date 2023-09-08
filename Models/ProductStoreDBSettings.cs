using _WebAPIMongoDB.Interface;

namespace _WebAPIMongoDB.Models
{
    public class ProductStoreDBSettings : IProductSettings
    {
        public string ProductCollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
