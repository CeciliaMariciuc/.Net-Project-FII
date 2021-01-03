using Moq;
using Recommendation.Microservice.Data;
using Recommendation.Microservice.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Recommendation_Tests
{
    public class MovieMapRepositoryTests
    {
        private readonly Mock<IRecommendationDatabaseSettings> _mockContext;
        public MovieMapRepositoryTests()
        {
            _mockContext = new Mock<IRecommendationDatabaseSettings>();
        }

        [Fact]
        public async void MovieMapRepository_NoUser_With_Negative_Id()
        {
            int movieId = -100;

            _mockContext.Setup(p => p.MovieMapCollectionName).Returns("movie_map");
            _mockContext.Setup(p => p.RatingTrainCollectionName).Returns("rating_train");
            _mockContext.Setup(p => p.ConnectionString).Returns("mongodb://localhost:27017");
            _mockContext.Setup(p => p.DatabaseName).Returns("RatingDB");
            var movieMapRepository = new MovieMapRepository(_mockContext.Object);

            Assert.Equal(null, await movieMapRepository.GetByMovieId(movieId));
        }
    }
}
