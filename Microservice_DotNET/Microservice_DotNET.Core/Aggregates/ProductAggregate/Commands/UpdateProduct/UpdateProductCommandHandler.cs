using AutoMapper;
using MediatR;
using Microservice_DotNET.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice_DotNET.Core.Aggregates.ProductAggregate.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;
        public UpdateProductCommandHandler(IRepository<Product> postRepository, IMapper mapper)
        {
            _productRepository = postRepository;
            _mapper = mapper;

            
        }
        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Product>(request);

            await _productRepository.UpdateAsync(post);

            return Unit.Value;
        }


    }
}
