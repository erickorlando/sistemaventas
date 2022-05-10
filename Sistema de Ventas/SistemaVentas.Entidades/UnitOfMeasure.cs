namespace SistemaVentas.Entidades;

public class UnitOfMeasure : EntityBase
{
    public string Code { get; set; } = null!;
    public string Description { get; set; } = null!;
    // Opcional
    public HashSet<Product> Products { get; set; } = null!;
}