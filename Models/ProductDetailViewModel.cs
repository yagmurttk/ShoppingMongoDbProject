using ShoppingMongo.Dtos.PDImageDtos;
using ShoppingMongo.Dtos.ProductDtos;
using ShoppingMongo.Entities;

namespace ShoppingMongo.Models
{
    public class ProductDetailViewModel
    {
        public GetProductByIdDto Product { get; set; }
        public List<GetPDImageByIdDto> Images { get; set; }
    }
}
