using MongoDB.Driver;
using Microsoft.Extensions.Options;
using System;
using Rating.Microservice.Model;

namespace RatingService.Microservice.Data
{
    public class DataContext
    {   public DataContext(IRatingsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            Ratings = database.GetCollection<RatingEntry>(settings.RatingsCollectionName);
        }

        public IMongoCollection<RatingEntry> Ratings { get; }
    }
}
