using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MovieCatalog.Microservice.Model
{
    [BsonIgnoreExtraElements]
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public List<string> Genre { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public List<string> Actors { get; set; }
        public int Year { get; set; }

        [BsonElement("Runtime (Minutes)")]
        public int Runtime { get; set; }
        public double Rating { get; set; }
        public int Votes { get; set; }

    }
}
