using Microsoft.Extensions.ML;
using Recommendation.Microservice.Data;
using Recommendation.Microservice.DataModels;
using Recommendation.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recommendation.Microservice.Helpers
{
    public class PredictionsService : IPredictionsService
    {
        private readonly PredictionEnginePool<MovieData, MoviePrediction> _predicitionEnginePool;
        private readonly IMovieMapRepository _repository;

        public PredictionsService(PredictionEnginePool<MovieData, MoviePrediction> predictionEnginePool, IMovieMapRepository repository)
        {
            _predicitionEnginePool = predictionEnginePool;
            _repository = repository;
        }

        public async Task<MovieMap> GetTopPrediction(float userId)
        {
            IEnumerable<MovieMap> movies = await _repository.GetAll();
            float bestScore = 0F;
            int bestMovieId = 1;
            foreach (MovieMap movie in movies)
            {
                MovieData movieData = new MovieData
                {
                    UserId = userId,
                    MovieId = movie.MovieId
                };

                var score = await PredictScore(movieData);
                if (score > bestScore)
                {
                    bestScore = score;
                    bestMovieId = movie.MovieId;
                }
            }

            return await _repository.GetByMovieId(bestMovieId);
        }

        public async Task<float> PredictScore(MovieData movieData)
        {
            MoviePrediction predictedValue =  _predicitionEnginePool.Predict(modelName: "MovieRecommendation", example: movieData);
            var score = predictedValue.Score;
            return score;
        }

        public async Task<IEnumerable<GeneralRating>> GetMappedMovies(IEnumerable<UserImdbRating> ratingList)
        {
            return await _repository.GetMappedMovies(ratingList);
        }
    }
}
