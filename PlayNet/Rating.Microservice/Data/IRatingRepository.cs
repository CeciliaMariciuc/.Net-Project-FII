using Rating.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rating.Microservice.Data
{
    public interface IRatingRepository  
    { 
        Task <IEnumerable<RatingEntry>> GetByMovieId(string movieId);
        Task<IEnumerable<string>> GetTop10ByPopularity();
        Task<IEnumerable<RatingEntry>> GetRatingsGivenByUser(string userId);
        Task<IEnumerable<PredictionMappedRating>> GetRatingsGivenByUserMap(string userId);
        Task<RatingEntry> GetById(string id);
        Task AddRating(RatingEntry rating);
        Task UpdateRating(string id, RatingEntry rating);
        Task DeleteRating(string id);
    }
}
