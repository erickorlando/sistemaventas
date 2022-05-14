namespace SistemaVentas.Entities;

public class Company : EntityBase
{
    public string Name { get; set; } = null!;

    public string IdentificationNumber { get; set; } = null!;

    public HashSet<Store> Stores { get; set; } = null!;
}