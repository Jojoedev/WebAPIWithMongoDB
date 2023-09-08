namespace _WebAPIMongoDB.Interface
{
    //This is for MongoDB Settings
    public interface IProductSettings 
    {
        string ProductCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
