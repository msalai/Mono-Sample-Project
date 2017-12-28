using AutoMapper;
using WebShopMono.DAL.Entities;
using WebShopMono.Model;
using WebShopMono.Model.Common;

namespace WebShopMono.Service
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<ProductEntity, Product>().ReverseMap();
            CreateMap<ProductEntity, IProduct>().ReverseMap();
            CreateMap<IProduct, Product>().ReverseMap();
        }
    }
}
