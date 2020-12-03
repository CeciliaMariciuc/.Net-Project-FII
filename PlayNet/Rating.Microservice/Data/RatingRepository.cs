using System;
using MongoDB.Driver;
using Rating.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using RatingService.Microservice.Data;

namespace Rating.Microservice.Data
{
    public class RatingRepository : IRatingRepository
    {
        private readonly DataContext _context;

        public RatingRepository(IRatingsDatabaseSettings settings)
        {
            _context = new DataContext(settings);
        }
        public async Task<RatingEntry> GetById(string id)
        {
            try
            {
                return await _context.Ratings
                                .Find(rating => rating.Id == id).
                                FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<IEnumerable<RatingEntry>> GetByMovieId(int movieId)
        {
            try
            {
                return await _context.Ratings
                                .Find(rating => rating.MovieId == movieId).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<IEnumerable<RatingEntry>> GetRatingsGivenByUser(int userId)
        {
            try
            {
                return await _context.Ratings
                                .Find(rating => rating.UserId == userId)
                                .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddRating(RatingEntry rating)
        {
            try
            {
                await _context.Ratings.InsertOneAsync(rating);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task UpdateRating(string id, RatingEntry rating)
        {
            try
            {
                await _context.Ratings.ReplaceOneAsync(rating => rating.Id == id, rating);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //stergem ratingul pt filmul cu numele ...
        public async Task DeleteRating(string id)
        {
            try
            {
                await _context.Ratings.DeleteOneAsync(rating => rating.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

    }
}
