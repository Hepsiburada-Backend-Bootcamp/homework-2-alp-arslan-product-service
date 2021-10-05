using AutoMapper;
using ProductNS.Domain.Models;

namespace ProductNS.Application.Dtos
{
    public class DtoMapping : Profile
    {
        public DtoMapping()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}
