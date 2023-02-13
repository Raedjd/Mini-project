using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice_DotNET.Core.Aggregates.ProductAggregate.Queries.GetProductDetail
{
    public class GetProductDetailQuery : IRequest<ProductDetailViewModel>
    {
         
        public Guid ProductId { get; set; }

    }
}

