namespace Microservice_DotNET.SharedKernel
{
    // This can be modified to BaseEntity<TId> to support multiple key types (e.g. Guid)
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}