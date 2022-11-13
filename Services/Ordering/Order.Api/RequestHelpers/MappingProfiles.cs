using AutoMapper;
using Order.Api.DTOs;
using Order.Api.Entities;

namespace Order.Api.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}