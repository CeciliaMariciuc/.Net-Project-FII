using MongoDB.Driver;
using MovieCatalog.Microservice.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieCatalog.Microservice.Data
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(IMoviesDatabaseSettings settings)
        {
            _context = new DataContext(settings);
        }

        public async Task<IEnumerable<Movie>> GetAll()
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

        public async Task<Movie> GetById(string id)
        {
            try
            {
                return await _context.Movies
                                .Find(movie => movie.Id == id)
                                .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        public async Task<IEnumerable<Movie>> GetFiltered(string title, string genre)
        {
            var filterByTitle = Builders<Movie>.Filter.
                Where(m => m.Title.ToLower().Contains(title.ToLower()));
            var filterByGenre = Builders<Movie>.Filter.Where(m => m.Genre.Contains(genre));
            var filter = Builders<Movie>.Filter.And(filterByTitle, filterByGenre);
            try
            {
                return await _context.Movies.Find(filter).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddMovie(Movie movie)
        {
            try
            {
                await _context.Movies.InsertOneAsync(movie);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateMovie(string id, Movie movie)
        {
            try
            {
                await _context.Movies.ReplaceOneAsync(movie => movie.Id == id, movie);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteMovie(string id)
        {
            try
            {
                await _context.Movies.DeleteOneAsync(movie => movie.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
