using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.AccesoDatos;

namespace SistemaVentas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var context = new SistemaVentasDbContext();

            var collection = await context.Customers.ToListAsync();

            return Ok(collection);
        }

    }
}
