namespace SistemaVentas.Entities;

public class Store : EntityBase
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string FullAddress { get; set; } = null!;

    public Company Company { get; set; } = null!;

    public int CompanyId { get; set; }
}