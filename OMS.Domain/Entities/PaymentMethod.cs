using OMS.Domain.Common;

namespace OMS.Domain.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;

        public PaymentMethod() { }

        public PaymentMethod(string name)
        {
            Name = name;
        }
    }

}
