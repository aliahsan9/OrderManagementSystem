
using OMS.Domain.Entities;

namespace OMS.Application.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetAsync(Order order);
        Task<Order?> GetByIdAsync(int id);
    }
}
