using AutoMapper;
using MangoServices.ProductAPI.Models;
using MangoServices.ProductAPI.Models.Dto;

namespace MangoServices.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;

        }
    }
}
