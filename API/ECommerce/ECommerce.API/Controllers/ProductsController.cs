using ECommerce.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducts(int? id)
        {
            if(id == null)
            {
                return BadRequest("Id cannot be null");
            }
            var product = await _context.Products.FindAsync(id);

            if(product == null)
            {
                return NotFound($"Product with id {id} not found");
            }

            return Ok(product);
        }
    }
}
