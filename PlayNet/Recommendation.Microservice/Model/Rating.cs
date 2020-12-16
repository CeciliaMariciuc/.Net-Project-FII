using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendation.Microservice.Model
{
    [BsonIgnoreExtraElements]
    public class Rating
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("userId")]
        public int UserId { get; set; }
        [BsonElement("movieId")]
        public int MovieId { get; set; }
        [BsonElement("rating")]
        public double RatingValue { get; set; }
    }
}
