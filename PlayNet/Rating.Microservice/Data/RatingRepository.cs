﻿using System;
using MongoDB.Driver;
using Rating.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using RatingService.Microservice.Data;
using System.Linq;

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

        public async Task<IEnumerable<RatingEntry>> GetByMovieId(string movieId)
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

        public async Task<IEnumerable<string>> GetTop10ByPopularity()
        {
            try
            {
                IEnumerable<RatingEntry> ratings = await _context.Ratings
                                .Find(rating => true).ToListAsync();
                IEnumerable<string> most_popular = ratings.GroupBy(r => r.MovieId)
                                                          .OrderByDescending(grp => grp.Count())
                                                          .Select(grp => grp.Key).Take(10);
                return most_popular;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<IEnumerable<RatingEntry>> GetRatingsGivenByUser(string userId)
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

        public async Task<IEnumerable<PredictionMappedRating>> GetRatingsGivenByUserMap(string userId)
        {
            try
            {
                List<RatingEntry> ratings = await _context.Ratings
                                .Find(rating => rating.UserId == userId)
                                .ToListAsync();
                List<PredictionMappedRating> mappedRatings =
                    ratings.Select(r => new PredictionMappedRating { MovieTitle = r.MovieTitle, RatingValue = r.Rated }).ToList();
                return mappedRatings;
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
