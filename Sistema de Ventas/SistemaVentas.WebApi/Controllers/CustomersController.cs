using Microsoft.AspNetCore.Mvc;
using SistemasVentas.Dto.Request;
using SistemasVentas.Services;

namespace SistemaVentas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomersController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string? filter)
        {
            return Ok(await _service.GetAllAsync(filter));
        }

        [HttpGet("deleted")]
        public async Task<IActionResult> GetAllIncludeDeleted()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _service.GetByIdAsync(id);

            return response.Success ? Ok(response) : NotFound(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerDtoRequest request)
        {
            return Ok(await _service.CreateAsync(request));
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody] CustomerDtoRequest request)
        {
            return Ok(await _service.UpdateAsync(id, request));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            return Ok(await _service.DeleteAsync(id));
        }
    }
}
