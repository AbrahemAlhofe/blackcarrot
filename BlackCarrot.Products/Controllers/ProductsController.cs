using BlackCarrot.Data.Models;
using BlackCarrot.Data.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace BlackCarrot.Products.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly ILogger<ProductsController> _logger;
        private readonly ProductsContext _context;

        public ProductsController(ProductsContext Context, ILogger<ProductsController> logger)
        {
            _logger = logger;
            _context = Context;
        }

        [HttpPost(Name = "Add Product")]
        public ActionResult<ProductModel> Post([FromBody]ProductModel Product)
        {
            try
            {
                _context.Products.Add(Product);
                _context.SaveChanges();
                return Product;
            } catch (Exception exception)
            {
                return StatusCode(409);
            }
        }
    }
}