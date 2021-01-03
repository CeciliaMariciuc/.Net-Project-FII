using Moq;
using Rating.Microservice.Model;
using Rating.Microservice.Data;
using System;
using Xunit;

namespace Rating_Tests
{
    public class RatingRepositoryTests
    {

        private readonly Mock<IRatingsDatabaseSettings> _mockContext;
        public RatingRepositoryTests()
        {
            _mockContext = new Mock<IRatingsDatabaseSettings>();
        }

        [Fact]
        public async void RatingRepository_Post_NullRating_Failure()
        {
            RatingEntry _rating = null;

            _mockContext.Setup(p => p.RatingsCollectionName).Returns("ratings");
            _mockContext.Setup(p => p.ConnectionString).Returns("mongodb://localhost:27017");
            _mockContext.Setup(p => p.DatabaseName).Returns("RatingDB");
            var ratingRepository = new RatingRepository(_mockContext.Object);

            await Assert.ThrowsAsync<ArgumentNullException>(() => ratingRepository.AddRating(_rating));
        }
    }
}
