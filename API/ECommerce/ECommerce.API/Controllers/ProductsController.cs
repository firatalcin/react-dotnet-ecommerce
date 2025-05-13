using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok("Get all products");
        }

        [HttpGet("{id}")]
        public IActionResult GetProducts(int id)
        {
            return Ok($"Get product with id {id}");
        }
    }
}
