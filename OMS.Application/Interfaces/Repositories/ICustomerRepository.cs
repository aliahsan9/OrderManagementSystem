
using OMS.Domain.Entities;

namespace OMS.Application.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(int id);
    }
}
