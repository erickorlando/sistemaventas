using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.AccesoDatos;
using SistemaVentas.Entidades;

namespace SistemaVentas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly SistemaVentasDbContext _context;

        public CustomersController(SistemaVentasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var collection = await _context.Set<Customer>().ToListAsync();

            return Ok(collection);
        }

    }
}
