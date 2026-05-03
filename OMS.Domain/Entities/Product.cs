using OMS.Domain.Common;

namespace OMS.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; }

        private Product() { }

        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            StockQuantity = stock;
        }

        public void Reducestock(int quantity)
        {
            if(StockQuantity < quantity)
            {
                throw new Exception("InSufficient Stock!");
            }
            StockQuantity -= quantity;
        }
    }
}
