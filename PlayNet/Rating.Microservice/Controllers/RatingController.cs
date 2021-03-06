﻿using Microsoft.AspNetCore.Mvc;
using Rating.Microservice.Data;
using Rating.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rating.Microservice.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]

    public class RatingController : ControllerBase
    {
        private readonly IRatingRepository _repository;

        public RatingController(IRatingRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("movie/{movieId}")]
        public async Task<IEnumerable<RatingEntry>> GetByMovieId(string movieId)
            {
            return await _repository.GetByMovieId(movieId);
        }

        [HttpGet("top10-popular")]
        public async Task<IEnumerable<string>> GetByPopularity()
        {
            return await _repository.GetTop10ByPopularity();
        }

        [HttpGet("{id}")]
        public async Task<RatingEntry> GetById(string id)
        {
            return await _repository.GetById(id);
        }


        [HttpGet("user/{userId}")]
        public async Task<IEnumerable<RatingEntry>> GetRatingsGivenByUser(string userId)
        {
            return await _repository.GetRatingsGivenByUser(userId);
             
        }

        [HttpGet("user-mapped/{userId}")]
        public async Task<IEnumerable<PredictionMappedRating>> GetRatingsGivenByUserMapped(string userId)
        {
            return await _repository.GetRatingsGivenByUserMap(userId);

        }

        [HttpPost]
        public async Task<IActionResult> Insert(RatingEntry rating)
        {
            await _repository.AddRating(rating);
            return CreatedAtAction("GetRatingsGivenByUser", new { userId = rating.UserId }, rating);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, RatingEntry rating)
        {
            if (id != rating.Id)
            {
                return BadRequest();
            }

            RatingEntry requestedMovie = await _repository.GetById(id);
            if (requestedMovie == null)
            {
                return NotFound();
            }
            await _repository.UpdateRating(id, rating);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            RatingEntry requestedMovie = await _repository.GetById(id);
            if (requestedMovie == null)
            {
                return NotFound();
            }
            await _repository.DeleteRating(id);
            return NoContent();
        }
    }
}
