using System.ComponentModel.DataAnnotations;

namespace SistemasVentas.Dto.Request;

public class CustomerDtoRequest
{
    [Required]
    public string FullName { get; set; } = null!;

    [Required]
    public string DocumentNumber { get; set; } = null!;

    public int TypeDocument { get; set; }

    public string? BirthDate { get; set; }

    [EmailAddress]
    public string Email { get; set; } = null!;

    public ICollection<AddressRequestDto>? Addresses { get; set; }
}

public class AddressRequestDto
{
    [Required]
    public string Name { get; set; } = null!;
    
    [Required]
    public string Address { get; set; } = null!;

    public bool DefaultAddress { get; set; }
}