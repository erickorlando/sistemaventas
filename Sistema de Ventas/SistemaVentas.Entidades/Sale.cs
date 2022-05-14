namespace SistemaVentas.Entities;

public class Sale : EntityBase
{
    public string InvoiceNumber { get; set; } = null!;

    public DateTime SaleDate { get; set; }

    public Customer Customer { get; set; } = null!;

    public int CustomerId { get; set; }

    public CustomerAddress? CustomerAddress { get; set; }

    public int? CustomerAddressId { get; set; }

    public Store Store { get; set; } = null!;

    public int StoreId { get; set; }

    public decimal TotalSale { get; set; }

    public decimal Taxes { get; set; }

    public decimal GrandTotal { get; set; }
}