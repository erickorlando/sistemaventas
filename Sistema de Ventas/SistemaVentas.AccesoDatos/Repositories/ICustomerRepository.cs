using SistemaVentas.Entities;

namespace SistemaVentas.DataAccess.Repositories;

public interface ICustomerRepository
{
    Task<ICollection<Customer>> GetAllAsync(string? name);
    Task<ICollection<Customer>> GetAllAsync();
    Task<Customer?> GetByIdAsync(int id);
    Task<int> CreateAsync(Customer customer);
    Task UpdateAsync();
    Task DeleteAsync(int id);
}