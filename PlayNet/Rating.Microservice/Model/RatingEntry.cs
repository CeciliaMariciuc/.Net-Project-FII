
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Rating.Microservice.Model
{
    [BsonIgnoreExtraElements]
    public class RatingEntry
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieId { get; set; }
        public int UserRating { get; set; }
        //public double Rated { get; set; }
        //public int Votes { get; set; }

    }
}
