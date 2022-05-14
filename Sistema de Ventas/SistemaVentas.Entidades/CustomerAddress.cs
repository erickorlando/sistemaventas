namespace SistemaVentas.Entities;

public class CustomerAddress : EntityBase
{
    public Customer Customer { get; set; } = null!;

    public int CustomerId { get; set; }

    public string Address { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool DefaultAddress { get; set; }
}