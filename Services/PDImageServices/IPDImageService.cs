using ShoppingMongo.Dtos.PDImageDtos;

namespace ShoppingMongo.Services.PDImageServices
{
    public interface IPDImageService
    {
        Task<List<ResultPDImageDto>> GetAllPDImageAsync();
        Task CreatePDImageAsync(CreatePDImageDto createPDImageDto);
        Task UpdatePDImageAsync(UpdatePDImageDto updatePDImageDto);
        Task DeletePDImageAsync(string id);
        Task<GetPDImageByIdDto> GetPDImageByIdAsync(string id);
        Task<List<GetPDImageByIdDto>> GetPDImageByProductIdAsync(string productId);
    }
}
