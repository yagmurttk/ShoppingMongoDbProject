using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingMongo.Entities
{
    public class PDImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PDImageId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public Product Product { get; set; }
    }
}
