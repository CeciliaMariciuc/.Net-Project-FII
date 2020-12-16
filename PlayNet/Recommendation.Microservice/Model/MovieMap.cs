using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendation.Microservice.Model
{
    public class MovieMap
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("movieId")]
        public int MovieId { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("genres")]
        public string Genres { get; set; }
    }
}
