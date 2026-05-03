
namespace OMS.Application.DTOs.Orders
{
    public class OrderResponse
    {
        public int Id { get; set; }
        public int CustomeId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<OrderItemResponse> Items { get; set; } = new();
    }
}
