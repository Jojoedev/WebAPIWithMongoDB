using _WebAPIMongoDB.Models;

namespace _WebAPIMongoDB.Data
{
    public static class ProductDB
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){Id = 1, Name = "Jameson", Category ="Wine", Quantity=23},
            new Product(){Id = 2, Name = "Peak Milk", Category ="Beverages", Quantity=103},
            new Product(){Id = 3, Name = "Knorr", Category ="Seasoning", Quantity=654},
        };
    }
}
