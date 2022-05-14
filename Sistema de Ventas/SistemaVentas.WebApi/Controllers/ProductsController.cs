using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.DataAccess;
using SistemaVentas.Entities;

namespace SistemaVentas.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly SistemaVentasDbContext _context;

    public ProductsController(SistemaVentasDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _context.Set<Product>()
            .Include(p => p.UnitOfMeasure)
            .Select(p => new
            {
                p.Id,
                p.Name,
                UnidadMedida = p.UnitOfMeasure.Description,
                p.SkuCode
            })
            .ToListAsync());
    }

    [HttpGet("unidades")]
    public async Task<IActionResult> GetByUnitOfMeasure()
    {
        return Ok(await _context.Set<UnitOfMeasure>()
            .Include(x => x.Products)
            .Select(x => new
            {
                UnidadMedida = x.Description,
                Productos = x.Products.Select(p => p.Name)
            })
            .OrderBy(p => p.UnidadMedida)
            .ToListAsync());
    }
}