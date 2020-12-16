using Recommendation.Microservice.DataModels;
using Recommendation.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recommendation.Microservice.Helpers
{
    public interface IPredictionsService
    {
        Task<MovieMap> GetTopPrediction(float userId);
        Task<float> PredictScore(MovieData movieData);
        Task<IEnumerable<GeneralRating>> GetMappedMovies(IEnumerable<UserImdbRating> ratingList);
    }
}