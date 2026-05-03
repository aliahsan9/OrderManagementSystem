
namespace OMS.Application.DTOs.Transactions
{
    public class TransactionResponse
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
