using Microservice_DotNET.SharedKernel.Interfaces;
using Microservice_DotNET.SharedKernel;

namespace Microservice_DotNET.Core.Aggregates.ProductAggregate
{
    public class Category : BaseEntity, IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}