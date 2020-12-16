using Recommendation.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recommendation.Microservice.Data
{
    public interface IRatingRepository
    {
        Task<IEnumerable<Rating>> GetAll();
        Task<int> GetMostSimilarUser(IEnumerable<GeneralRating> ratingList);
    }
}