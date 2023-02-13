using AutoMapper;
using MediatR;


namespace Microservice_DotNET.Core.Aggregates.ProductAggregate.Commands.AddProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);

            var validator = new CreateProductCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Product is not valid");
            }

            product = await _productRepository.AddAsync(product);

            return product.Id;
        }
    }
}

   

