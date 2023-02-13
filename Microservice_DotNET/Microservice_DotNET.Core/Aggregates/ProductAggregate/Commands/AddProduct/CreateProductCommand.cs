using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice_DotNET.Core.Aggregates.ProductAggregate.Commands.AddProduct
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
      
        public Guid CategoryId { get; set; }
    }
}

