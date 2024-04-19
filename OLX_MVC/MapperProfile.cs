using AutoMapper;
using OLX_MVC.Data.Entities;
using OLX_MVC.Models;

namespace OLX_MVC
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ProductFormModel, Product>().ReverseMap();
            CreateMap<Product, ProductFeaturedModel>();
        }
    }
}
