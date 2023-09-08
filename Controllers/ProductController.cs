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
        [HttpGet("id")]
        public ActionResult<Product> GetOneProduct(int id)
        {
            var product = _productInterface.GetById(id);
            if(product == null)
            {
                return NotFound();
            }
            return product;

        }

        [HttpPost]
        public ActionResult<Product> CreateNew(Product product)
        {
            var newProduct = _productInterface.Create(product);

            return CreatedAtAction(nameof(GetOneProduct), new { id = product.Id }, product);
        }

    }
}
