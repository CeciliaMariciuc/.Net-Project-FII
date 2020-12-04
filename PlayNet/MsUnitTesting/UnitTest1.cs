using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MsUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<IMovieRepository> mockMovieRepository;
        private MovieController movieController;

        [TestInitialize]
        public void Initializer()
        {
            mockMovieRepository = new Mock<IMovieRepository>();
            movieController = new MovieController(mockMovieRepository.Object);

        }


        [TestMethod]
        public void TestMethod1()
        {
            [DataRow("5fc9854c5f617979d412c0b5")]
            public async Task 
            MovieController_GetMovies_GetMoviesById_ReturnMoviesList(string id)
            {
                //Arrange
              
                var moviesList = new List<Movie> {
                new Movie{ Title="Film 1", Id="5fc9854c5f61797912345670" },
                new Movie{ Title="Film 2", Id="5fc9854c5f61797913456708" },
                new Movie{ Title="Film 3", Id="5fc9854c5f617978134567089"}
            };

                }
            }
    }

    internal interface IMovieRepository
    {
    }

    internal class MovieController
    {
    }
}
