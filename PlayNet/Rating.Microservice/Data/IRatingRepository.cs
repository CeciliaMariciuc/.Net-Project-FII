using Rating.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rating.Microservice.Data
{
    public interface IRatingRepository  
    { 
        Task <IEnumerable<RatingEntry>> GetByMovieId(int movieId);
        Task<IEnumerable<RatingEntry>> GetRatingsGivenByUser(int userId);
        Task<RatingEntry> GetById(string id);
        Task AddRating(RatingEntry rating);
        Task UpdateRating(string id, RatingEntry rating);
        Task DeleteRating(string id);
    }
}
