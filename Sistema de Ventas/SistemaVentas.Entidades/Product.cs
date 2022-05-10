namespace SistemaVentas.Entidades;

public class Product : EntityBase
{
    public string Name { get; set; } = null!;
    public string SkuCode { get; set; } = null!;
    public DateTime? RegisterDate { get; set; }
    public UnitOfMeasure UnitOfMeasure { get; set; } = null!;
    public int UnitOfMeasureId { get; set; }
    public string? Notes { get; set; }
}