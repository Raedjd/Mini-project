using Microservice_DotNET.SharedKernel;
using Microservice_DotNET.SharedKernel.Interfaces;


namespace Microservice_DotNET.Core.Aggregates.ProductAggregate
{
      public class Product : BaseEntity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string ImageUrl { get; private set; }
        public Category Category { get; private set; }
        public Guid CategoryId { get; private set; }
    }
}
