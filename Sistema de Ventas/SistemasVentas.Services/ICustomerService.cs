using SistemasVentas.Dto.Request;
using SistemasVentas.Dto.Response;

namespace SistemasVentas.Services;

public interface ICustomerService
{
    Task<ResponseBaseGeneric<ICollection<CustomerDto>>> GetAllAsync(string? name);
    Task<ResponseBaseGeneric<ICollection<CustomerDto>>> GetAllAsync();
    Task<ResponseBaseGeneric<CustomerDto>> GetByIdAsync(int id);
    Task<ResponseBaseGeneric<int>> CreateAsync(CustomerDtoRequest request);
    Task<ResponseBase> UpdateAsync(int id, CustomerDtoRequest request);
    Task<ResponseBase> DeleteAsync(int id);
}