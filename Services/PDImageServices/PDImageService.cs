using AutoMapper;
using MongoDB.Driver;
using ShoppingMongo.Dtos.PDImageDtos;
using ShoppingMongo.Entities;
using ShoppingMongo.Settings;

namespace ShoppingMongo.Services.PDImageServices
{
    public class PDImageService : IPDImageService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<PDImage> _pdimageCollection;

        public PDImageService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _pdimageCollection = database.GetCollection<PDImage>(_databaseSettings.PDImageCollectionName);
            _mapper = mapper;
        }

        public async Task CreatePDImageAsync(CreatePDImageDto createPDImageDto)
        {
            var value = _mapper.Map<PDImage>(createPDImageDto);
            await _pdimageCollection.InsertOneAsync(value);
        }

        public async Task DeletePDImageAsync(string id)
        {
            await _pdimageCollection.DeleteOneAsync(x => x.PDImageId == id);
        }

        public async Task<List<ResultPDImageDto>> GetAllPDImageAsync()
        {
            var values = await _pdimageCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultPDImageDto>>(values);
        }

        public async Task<GetPDImageByIdDto> GetPDImageByIdAsync(string id)
        {
            var value = await _pdimageCollection.Find(x => x.PDImageId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetPDImageByIdDto>(value);
        }

        public async Task UpdatePDImageAsync(UpdatePDImageDto updatePDImageDto)
        {
            var value = _mapper.Map<PDImage>(updatePDImageDto);
            await _pdimageCollection.FindOneAndReplaceAsync(x => x.PDImageId == updatePDImageDto.PDImageId, value);
        }

        public async Task<List<GetPDImageByIdDto>> GetPDImageByProductIdAsync(string productId)
        {
            var values = await _pdimageCollection.Find(x => x.ProductId == productId).ToListAsync();
            return _mapper.Map<List<GetPDImageByIdDto>>(values);
        }

    }
}
