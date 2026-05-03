
using OMS.Domain.Entities;

namespace OMS.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(int id);
    }
}
