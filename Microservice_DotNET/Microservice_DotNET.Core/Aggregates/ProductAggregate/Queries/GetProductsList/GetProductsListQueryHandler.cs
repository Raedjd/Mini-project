using AutoMapper;
using MediatR;
using Microservice_DotNET.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice_DotNET.Core.Aggregates.ProductAggregate.Queries.GetProductsList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<ProductsListViewModel>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IProductRepository postRepository, IMapper mapper)
        {
            _productRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductsListViewModel>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var allProducts = await _productRepository.GetAllProductsAsync(true);
            return _mapper.Map<List<ProductsListViewModel>>(allProducts);
        }
    }
}
