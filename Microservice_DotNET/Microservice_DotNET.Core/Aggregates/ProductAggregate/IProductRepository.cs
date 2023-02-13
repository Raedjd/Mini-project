using Microservice_DotNET.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice_DotNET.Core.Aggregates.ProductAggregate
{
  public interface IProductRepository : IRepository<Product>
    {
        Task<IReadOnlyList<Product>> GetAllProductsAsync(bool includeCategory);
        Task<Product> GetProductByIdAsync(Guid id, bool includeCategory);
    }
}
