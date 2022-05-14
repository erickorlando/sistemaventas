namespace SistemaVentas.Entities;

public class SaleDetail : EntityBase
{
    public Sale Sale { get; set; } = null!;

    public int SaleId { get; set; }

    public Product Product { get; set; } = null!;

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Quantity { get; set; }

    public decimal Taxes { get; set; }

    public decimal TotalSale { get; set; }
}