using MongoDB.Driver;
using Recommendation.Microservice.Model;

namespace Recommendation.Microservice.Data
{
    public class DataContext
    {
        public DataContext(IRecommendationDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            Movies = database.GetCollection<MovieMap>(settings.MovieMapCollectionName);
            Ratings = database.GetCollection<Rating>(settings.RatingTrainCollectionName);
        }

        public IMongoCollection<MovieMap> Movies { get; }
        public IMongoCollection<Rating> Ratings { get; }
    }
}
