using Microsoft.Extensions.ML;
using Recommendation.Microservice.Data;
using Recommendation.Microservice.DataModels;
using Recommendation.Microservice.Model;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<MovieMap>> GetTop10Prediction(float userId)
        {
            IEnumerable<MovieMap> movies = await _repository.GetAll();
            List<MovieScore> scores = new List<MovieScore>();
            List<MovieMap> bestMovies = new List<MovieMap>();
            foreach (MovieMap movie in movies)
            {
                MovieData movieData = new MovieData
                {
                    UserId = userId,
                    MovieId = movie.MovieId
                };

                var score = await PredictScore(movieData);
                MovieScore movieScore = new MovieScore
                {
                    MovieId = movie.MovieId,
                    Score = score
                };
                if (scores.Count < 10)
                {
                    scores.Add(movieScore);
                }
                else
                {
                    MovieScore minimum_score = scores.OrderByDescending(s => s.Score).First();
                    if(score > minimum_score.Score)
                    {
                        scores.Remove(minimum_score);
                        scores.Add(movieScore);
                    }
                }
            }

            List<MovieScore> sortedScores = scores.OrderByDescending(s => s.Score).ToList();
            foreach(MovieScore movieScore in sortedScores)
            {
                bestMovies.Add(await _repository.GetByMovieId(movieScore.MovieId));
            }
            return bestMovies;
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
