using BlackCarrot.Data.Contexts;
using BlackCarrot.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlackCarrot.Search.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {

        private readonly ILogger<SearchController> _logger;

        private readonly ProductsContext _context;

        public SearchController(ProductsContext Context, ILogger<SearchController> logger)
        {
            _logger = logger;
            _context = Context;
        }

        [HttpGet(Name = "Search")]
        public IEnumerable<ProductModel> Get()
        {
            return _context.Products.ToList();
        }
    }
}