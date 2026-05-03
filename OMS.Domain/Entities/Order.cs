using OMS.Domain.Common;

namespace OMS.Domain.Entities;

public class Order : AuditableEntity
{
    public int CustomerId { get; private set; }
    public decimal TotalAmount { get; private set; }
    public string Status { get; private set; } = "Pending";

    public byte[] RowVersion { get; private set; } = null!; // Concurrency

    private readonly List<OrderItem> _items = new();
    public IReadOnlyCollection<OrderItem> Items => _items;

    private Order() { }

    public Order(int customerId)
    {
        CustomerId = customerId;
    }

    public void AddItem(int productId, int quantity, decimal price)
    {
        var item = new OrderItem(productId, quantity, price);
        _items.Add(item);

        TotalAmount += item.TotalPrice;
    }

    public void MarkAsPaid()
    {
        Status = "Paid";
    }

    public void Cancel()
    {
        Status = "Cancelled";
    }
}