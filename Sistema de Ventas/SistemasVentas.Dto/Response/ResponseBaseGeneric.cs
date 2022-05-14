namespace SistemasVentas.Dto.Response;

public class ResponseBaseGeneric<TResult> : ResponseBase
{
    public TResult? Result { get; set; } = default;
}