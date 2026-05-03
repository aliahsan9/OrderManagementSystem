namespace OMS.Domain.Common
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } 

        public void SetUpdated()
        {
            UpdatedAt = DateTime.UtcNow();
        }
    }
}
