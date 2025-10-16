using AutoMapper;
using ShoppingMongo.Dtos.CategoryDtos;
using ShoppingMongo.Dtos.PDImageDtos;
using ShoppingMongo.Dtos.ProductDtos;
using ShoppingMongo.Dtos.SliderDtos;
using ShoppingMongo.Entities;

namespace ShoppingMongo.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryByIdDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductByIdDto>().ReverseMap();

            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, GetSliderByIdDto>().ReverseMap();

            CreateMap<PDImage, CreatePDImageDto>().ReverseMap();
            CreateMap<PDImage, ResultPDImageDto>().ReverseMap();
            CreateMap<PDImage, UpdatePDImageDto>().ReverseMap();
            CreateMap<PDImage,GetPDImageByIdDto>().ReverseMap();
        }
    }
}