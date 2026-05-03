
using OMS.Domain.Entities;

namespace OMS.Application.DTOs.Orders
{
    public class CreateOrderRequest
    {
        public int CustomerId { get; set; }
        public List<OrderItemRequest> Items { get; set; } = new();
    }
}
