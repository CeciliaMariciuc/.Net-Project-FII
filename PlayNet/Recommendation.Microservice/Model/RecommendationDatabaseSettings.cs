using System;

namespace Recommendation.Microservice.Model
{
    public class RecommendationDatabaseSettings : IRecommendationDatabaseSettings
    {
        public string MovieMapCollectionName { get; set; }
        public string RatingTrainCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IRecommendationDatabaseSettings
    {
        string MovieMapCollectionName { get; set; }
        string RatingTrainCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
