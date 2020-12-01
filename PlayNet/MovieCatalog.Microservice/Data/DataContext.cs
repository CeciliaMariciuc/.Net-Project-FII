using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieCatalog.Microservice.Model;
using System;

namespace MovieCatalog.Microservice.Data
{
    public class DataContext
    {
        public DataContext(IMoviesDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            Movies = database.GetCollection<Movie>(settings.MoviesCollectionName);
        }

        public IMongoCollection<Movie> Movies { get; }
    }
}
