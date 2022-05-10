namespace SistemaVentas.Entidades
{
    public class Customer : EntityBase
    {
        public string FullName { get; set; } = null!;

        public string DocumentNumber { get; set; } = null!;

        public TypeDocument TypeDocument { get; set; }
        
        public DateTime? BirthDate { get; set; }

        public string Email { get; set; } = null!;
    }
}