using Autentification.Data;
using Autentification.Model;
using MongoDB.Driver;
using Moq;
using System;
using Xunit;

namespace Authentication_Tests
{
    public class UserRepositoryTests
    {
        private readonly Mock<IUsersDatabaseSettings> _mockContext;
        public UserRepositoryTests()
        {
            _mockContext = new Mock<IUsersDatabaseSettings>();
        }

        [Fact]
        public async void UserRepository_Create_NullUser_Failure()
        {
            // Arrange
            User _user = null;

            //Act 
            _mockContext.Setup((p => p.UserCollectionName)).Returns("users");
            _mockContext.Setup((p => p.ConnectionString)).Returns("mongodb://localhost:27017");
            _mockContext.Setup((p => p.DatabaseName)).Returns("AuthenticationDB");
            var userRepository = new UserRepository(_mockContext.Object);

            // Assert
            await Assert.ThrowsAsync<ArgumentNullException>(() => userRepository.AddUser(_user));
        }

        [Fact]
        public async void UserRepository_NoUser_With_One_Letter_Email()
        {
            // Arrange
            string email = "a";

            //Act 
            _mockContext.Setup((p => p.UserCollectionName)).Returns("users");
            _mockContext.Setup((p => p.ConnectionString)).Returns("mongodb://localhost:27017");
            _mockContext.Setup((p => p.DatabaseName)).Returns("AuthenticationDB");
            var userRepository = new UserRepository(_mockContext.Object);

            // Assert
            Assert.False(await userRepository.IsEmailUsed(email));
        }
    }
}
