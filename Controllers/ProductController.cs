using _WebAPIMongoDB.Interface;
using _WebAPIMongoDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace _WebAPIMongoDB.Controllers
{
    [ApiController]

    [Route("api/products")]
   
    public class ProductController : Controller
    {
        
        private readonly IProductInterface _productInterface;

        public ProductController(IProductInterface productInterface)
        {
            _productInterface = productInterface;
        }

        [HttpGet]
        public IEnumerable<Product> Index()
        {
            return _productInterface.GetAll();
            
        }
    }
}
