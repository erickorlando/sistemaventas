namespace SistemasVentas.Dto.Response;

public class ResponseBase
{
    public bool Success { get; set; }

    public List<string> ErrorMessages { get; set; }

    public ResponseBase()
    {
        ErrorMessages = new List<string>();
    }
}