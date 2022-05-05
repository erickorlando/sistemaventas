using SistemaVentas.Entidades;

namespace SistemaVentas.WebBlazor.Data;

public class CustomerService
{
    public async Task<ICollection<Customer>> GetCustomers()
    {
        var list = new List<Customer>();

        var client = new HttpClient();
        client.BaseAddress = new Uri("https://localhost:2001/api/");

        var responseMessage = await client.GetAsync("customers");

        if (responseMessage.IsSuccessStatusCode)
        {
            var collection = await responseMessage.Content.ReadFromJsonAsync<ICollection<Customer>>();

            if (collection != null)
                list = collection.ToList();
        }

        return list;
    }
}