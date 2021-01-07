using MongoDB.Driver;
using Recommendation.Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendation.Microservice.Data
{
    public class RatingRepository : IRatingRepository
    {
        private readonly DataContext _context;
        public RatingRepository(IRecommendationDatabaseSettings settings)
        {
            _context = new DataContext(settings);
        }

        public async Task<IEnumerable<Rating>> GetAll()
        {
            try
            {
                return await _context.Ratings.Find(rating => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> GetMostSimilarUser(IEnumerable<GeneralRating> ratingList)
        {
            Dictionary<int, double> similarityUser = new Dictionary<int, double>();
            try
            {
                foreach (GeneralRating rating in ratingList)
                {
                    IEnumerable<Rating> userRatings = await _context.Ratings.Find(r => r.MovieId == rating.MovieId).ToListAsync();
                    foreach (Rating r in userRatings)
                    {
                         if (!similarityUser.ContainsKey(r.UserId))
                         {
                              similarityUser.Add(r.UserId, Math.Abs(r.RatingValue - rating.RatingValue)-0.1);
                         }
                         else
                         {
                             similarityUser[r.UserId] += Math.Abs(r.RatingValue - rating.RatingValue)-0.1;
                         }
                    }
                }
                return similarityUser.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
