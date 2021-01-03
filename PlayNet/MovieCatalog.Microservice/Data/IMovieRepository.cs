using MovieCatalog.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieCatalog.Microservice.Data
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAll();
        Task<Movie> GetById(string id);
        Task<List<Movie>> GetByIds(List<string> ids);
        Task<IEnumerable<Movie>> GetTop10Rated();
        Task<IEnumerable<Movie>> GetFiltered(string title, string genre, string sort, int sort_order);
        Task AddMovie(Movie movie);
        Task UpdateMovie(string id, Movie movie);
        Task DeleteMovie(string id);
    }
}