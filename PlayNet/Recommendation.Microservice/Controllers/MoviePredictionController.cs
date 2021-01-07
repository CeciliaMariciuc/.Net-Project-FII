using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recommendation.Microservice.Data;
using Recommendation.Microservice.DataModels;
using Recommendation.Microservice.Helpers;
using Recommendation.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recommendation.Microservice.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MoviePredictionController : ControllerBase
    {
        private readonly IPredictionsService _service;
        private readonly IRatingRepository _ratingRepository;

        public MoviePredictionController(IPredictionsService predictionService, IRatingRepository ratingRepository)
        {
            _service = predictionService;
            _ratingRepository = ratingRepository;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<MovieMap>> GetTopPrediction([FromBody] MovieData movieData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            MovieMap movie = await _service.GetTopPrediction(movieData.UserId);
            if(movie == null)
            {
               return NotFound();
            }
            return Ok(movie);
        }

        [HttpPost("score")]
        public async Task<ActionResult<float>> GetMovieScore([FromBody] MovieData movieData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var score = await _service.PredictScore(movieData);
            return Ok(score);
        }

        [HttpPost("similar-user")]
        public async Task<ActionResult<int>> GetMostSimilarUser([FromBody] IEnumerable<GeneralRating> ratingList)
        {
            int userId = await _ratingRepository.GetMostSimilarUser(ratingList);
            return Ok(userId);
        }

        [HttpPost("map-movies")]
        public async Task<ActionResult<IEnumerable<GeneralRating>>> GetCorrespondentMovies([FromBody] IEnumerable<UserImdbRating> ratingList)
        {
            IEnumerable<GeneralRating> mappedRatings = await _service.GetMappedMovies(ratingList);
            return Ok(mappedRatings);
        }

    }
}
