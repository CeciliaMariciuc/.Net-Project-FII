using Recommendation.Microservice.DataModels;
using Recommendation.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recommendation.Microservice.Helpers
{
    public interface IPredictionsService
    {
        Task<List<MovieMap>> GetTop10Prediction(float userId);
        Task<float> PredictScore(MovieData movieData);
        Task<IEnumerable<GeneralRating>> GetMappedMovies(IEnumerable<UserImdbRating> ratingList);
    }
}