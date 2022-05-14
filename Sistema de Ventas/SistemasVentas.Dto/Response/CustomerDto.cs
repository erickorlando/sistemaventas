namespace SistemasVentas.Dto.Response;

public class CustomerDto
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;
}