using Microsoft.EntityFrameworkCore;
using SistemaVentas.Entities;

namespace SistemaVentas.DataAccess.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly SistemaVentasDbContext _context;

    public CustomerRepository(SistemaVentasDbContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Customer>> GetAllAsync(string? name)
    {
        return await _context.Set<Customer>()
            .Where(p => p.FullName.Contains(name ?? string.Empty))
            .OrderBy(p => p.FullName)
            .ToListAsync();
    }
    
    public async Task<ICollection<Customer>> GetAllAsync()
    {
        return await _context.Set<Customer>()
            .IgnoreQueryFilters()
            .OrderBy(p => p.FullName)
            .ToListAsync();
    }

    public async Task<Customer?> GetByIdAsync(int id)
    {
        return await _context.Set<Customer>().FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<int> CreateAsync(Customer customer)
    {
        await _context.AddAsync(customer);

        await _context.SaveChangesAsync();

        return customer.Id;
    }

    public async Task UpdateAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var customer = await _context.Set<Customer>()
            .FirstOrDefaultAsync(p => p.Id == id);

        if (customer != null)
        {
            customer.Status = false;

            await _context.SaveChangesAsync();
        }
    }
}