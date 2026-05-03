using OMS.Domain.Common;

namespace OMS.Domain.Entities
{
    public class Transaction : AuditableEntity
    {
        public int OrderId { get; private set; }
        public decimal Amount { get; private set; }
        public string PaymentMethod { get; private set; } = string.Empty;
        public string Status { get; private set; } = "pending";

        public int PaymentMethodId{ get; private set; }

        private Transaction() { }

        public Transaction(int orderId, decimal amount, string paymentMethod, int paymentMethodId)
        {
            OrderId = orderId;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentMethodId = paymentMethodId;
        }
        public void MarkSuccess()
        {
            Status = "Success";
        }
        public void MarkFailed()
        {
            Status = "Failed";
        }
    }
}
