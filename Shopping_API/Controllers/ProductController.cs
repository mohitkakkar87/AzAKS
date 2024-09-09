using Microsoft.AspNetCore.Mvc;
using Shopping_API.Data;
using Shopping_API.Model;

namespace Shopping_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            //var rng = new Random();
            //return Enumerable.Range(0, 5).Select(index => new Product
            //{
            //    Id =index.ToString(),
            //    Name = "Mohit"
            //}).ToArray();
            return ProductContext.Products;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
