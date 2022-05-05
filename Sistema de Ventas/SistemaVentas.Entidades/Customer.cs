namespace SistemaVentas.Entidades
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string DocumentNumber { get; set; }
        public TypeDocument TypeDocument { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
    }
}