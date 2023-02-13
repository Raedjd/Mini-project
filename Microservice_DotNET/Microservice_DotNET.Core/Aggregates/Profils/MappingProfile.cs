using AutoMapper;
using Microservice_DotNET.Core.Aggregates.ProductAggregate;
using Microservice_DotNET.Core.Aggregates.ProductAggregate.Commands.AddProduct;
using Microservice_DotNET.Core.Aggregates.ProductAggregate.Queries.GetProductDetail;
using Microservice_DotNET.Core.Aggregates.ProductAggregate.Queries.GetProductsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice_DotNET.Core.Aggregates.Profils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductsListViewModel>().ReverseMap();
            CreateMap<Product, ProductDetailViewModel>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();







        }
    }
}
