
namespace Rating.Microservice.Model
{
    public class RatingsDatabaseSettings : IRatingsDatabaseSettings
    {
        public string RatingsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IRatingsDatabaseSettings
    {
        string RatingsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
