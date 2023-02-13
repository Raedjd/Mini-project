using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice_DotNET.Core.Aggregates.ProductAggregate.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public Guid PostId { get; set; }
    }
}
