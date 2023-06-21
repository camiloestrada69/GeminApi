namespace GeminApi.Domain.models
{
    public abstract class AuditableBase
    {
        public virtual int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
