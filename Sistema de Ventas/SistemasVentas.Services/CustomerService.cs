using SistemasVentas.Dto.Request;
using SistemasVentas.Dto.Response;
using SistemaVentas.DataAccess.Repositories;
using SistemaVentas.Entities;

namespace SistemasVentas.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseBaseGeneric<ICollection<CustomerDto>>> GetAllAsync(string? name)
        {
            var response = new ResponseBaseGeneric<ICollection<CustomerDto>>();

            try
            {
                var collection = await _repository.GetAllAsync(name);

                response.Result = collection.Select(p => new CustomerDto
                {
                    Id = p.Id,
                    FullName = p.FullName,
                    Email = p.Email
                }).ToList();

                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessages.Add(ex.Message);
            }

            return response;
        }
        
        public async Task<ResponseBaseGeneric<ICollection<CustomerDto>>> GetAllAsync()
        {
            var response = new ResponseBaseGeneric<ICollection<CustomerDto>>();

            try
            {
                var collection = await _repository.GetAllAsync();

                response.Result = collection.Select(p => new CustomerDto
                {
                    Id = p.Id,
                    FullName = p.FullName,
                    Email = p.Email
                }).ToList();

                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessages.Add(ex.Message);
            }

            return response;
        }

        public async Task<ResponseBaseGeneric<CustomerDto>> GetByIdAsync(int id)
        {
            var response = new ResponseBaseGeneric<CustomerDto>();

            try
            {
                var customer = await _repository.GetByIdAsync(id);

                if (customer != null)
                {
                    response.Result = new CustomerDto
                    {
                        Id = customer.Id,
                        FullName = customer.FullName,
                        Email = customer.Email
                    };
                    response.Success = true;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessages.Add(ex.Message);
            }

            return response;
        }

        public async Task<ResponseBaseGeneric<int>> CreateAsync(CustomerDtoRequest request)
        {
            var response = new ResponseBaseGeneric<int>();

            try
            {
                response.Result = await _repository.CreateAsync(new Customer
                {
                    FullName = request.FullName,
                    Email = request.Email,
                    BirthDate = string.IsNullOrEmpty(request.BirthDate) ? null : Convert.ToDateTime(request.BirthDate),
                    DocumentNumber = request.DocumentNumber,
                    TypeDocument = (TypeDocument)request.TypeDocument,
                });

                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessages.Add(ex.Message);
            }

            return response;
        }

        public async Task<ResponseBase> UpdateAsync(int id, CustomerDtoRequest request)
        {
            var response = new ResponseBase();

            try
            {
                var customer = await _repository.GetByIdAsync(id);

                if (customer == null)
                {
                    throw new ApplicationException("No se encontró el registro");
                }

                customer.FullName = request.FullName;
                customer.Email = request.Email;
                customer.BirthDate = string.IsNullOrEmpty(request.BirthDate) ? null : Convert.ToDateTime(request.BirthDate);
                customer.DocumentNumber = request.DocumentNumber;
                customer.TypeDocument = (TypeDocument)request.TypeDocument;

                await _repository.UpdateAsync();

                response.Success = true; 
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessages.Add(ex.Message);
            }

            return response;
        }

        public async Task<ResponseBase> DeleteAsync(int id)
        {
            var response = new ResponseBase();

            try
            {
                await _repository.DeleteAsync(id);
                response.Success = true;
            }
            catch (Exception ex)
            {
                
                response.Success = false;
                response.ErrorMessages.Add(ex.Message);
            }

            return response;
        }
    }
}