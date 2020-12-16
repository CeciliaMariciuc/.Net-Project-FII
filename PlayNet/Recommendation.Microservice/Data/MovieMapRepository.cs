using MongoDB.Driver;
using Recommendation.Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendation.Microservice.Data
{
    public class MovieMapRepository : IMovieMapRepository
    {
        private readonly DataContext _context;

        public MovieMapRepository(IRecommendationDatabaseSettings settings)
        {
            _context = new DataContext(settings);
        }

        public async Task<IEnumerable<MovieMap>> GetAll()
        {
            try
            {
                return await _context.Movies.Find(movie => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<MovieMap> GetByMovieId(int movieId)
        {
            try
            {
                return await _context.Movies
                                .Find(movie => movie.MovieId == movieId)
                                .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<GeneralRating>> GetMappedMovies(IEnumerable<UserImdbRating> ratingList)
        {
            try
            {
                List<GeneralRating> mappedRatings = new List<GeneralRating>();
                foreach (UserImdbRating imdbRating in ratingList)
                {
                    MovieMap movie = await _context.Movies
                                   .Find(movie => movie.Title.ToLower().Contains(imdbRating.MovieTitle.ToLower()))
                                   .FirstOrDefaultAsync();
                    if(movie != null)
                    {
                        GeneralRating mappedRating = new GeneralRating
                        {
                            MovieId = movie.MovieId,
                            RatingValue = imdbRating.RatingValue / 2
                        };
                        mappedRatings.Add(mappedRating);
                    }
                }
                return mappedRatings;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
