using Moq;
using MovieCatalog.Microservice.Data;
using MovieCatalog.Microservice.Model;
using System;
using Xunit;

namespace MovieCatalog_Tests
{
    public class MovieRepositoryTests
    {
        private readonly Mock<IMoviesDatabaseSettings> _mockContext;
        public MovieRepositoryTests()
        {
            _mockContext = new Mock<IMoviesDatabaseSettings>();
        }

        [Fact]
        public async void MovieRepository_Create_NullUser_Failure()
        {
            // Arrange
            Movie _movie = null;

            //Act 
            _mockContext.Setup((p => p.MoviesCollectionName)).Returns("movies");
            _mockContext.Setup((p => p.ConnectionString)).Returns("mongodb://localhost:27017");
            _mockContext.Setup((p => p.DatabaseName)).Returns("MovieCatalog");
            var movieRepository = new MovieRepository(_mockContext.Object);

            // Assert
            await Assert.ThrowsAsync<ArgumentNullException>(() => movieRepository.AddMovie(_movie));
        }

    }
}
