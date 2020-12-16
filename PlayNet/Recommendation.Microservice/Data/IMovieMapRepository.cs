using Recommendation.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recommendation.Microservice.Data
{
    public interface IMovieMapRepository
    {
        Task<IEnumerable<MovieMap>> GetAll();
        Task<MovieMap> GetByMovieId(int movieId);
        Task<IEnumerable<GeneralRating>> GetMappedMovies(IEnumerable<UserImdbRating> ratingList);
    }
}