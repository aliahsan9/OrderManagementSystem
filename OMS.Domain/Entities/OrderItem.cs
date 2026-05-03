using OMS.Domain.Common;

namespace OMS.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int OrderId { get; private set; }
        public int ProductId { get; private set; }

        public int Quantity { get; private set; }
        public decimal UnitPrice{ get; private set; }
        public decimal TotalPrice { get; private set; }

        private OrderItem() { }

        public OrderItem(int productId, int quantity, decimal unitPrice)
        {
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = quantity * unitPrice;
        }
    }
}
