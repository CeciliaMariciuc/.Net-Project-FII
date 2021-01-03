using Microsoft.AspNetCore.Mvc;
using MovieCatalog.Microservice.Data;
using MovieCatalog.Microservice.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MovieCatalog.Microservice.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _repository;

        public MoviesController(IMovieRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Movie>> Get()
        {
            return await _repository.GetAll();
        }

        [HttpGet("top10")]
        public async Task<IEnumerable<Movie>> GetTop10()
        {
            return await _repository.GetTop10Rated();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetById(string id)
        {
            Movie movie =  await _repository.GetById(id);
            if(movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        [HttpPost("ids")]
        public async Task<ActionResult<List<Movie>>> GetByIds(List<string> ids)
        {
            return await _repository.GetByIds(ids);
        }

        [HttpGet("query")]
        public async Task<IEnumerable<Movie>> GetFiltered(
            [FromQuery] string title, 
            [FromQuery] string genre,
            [FromQuery] string sort,
            [FromQuery] int sort_order
            )
        {
            return await _repository.GetFiltered(title,genre,sort,sort_order);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(Movie movie)
        {
            await _repository.AddMovie(movie);
            return CreatedAtAction("GetById", new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Movie movie)
        {
            if(id != movie.Id)
            {
                return BadRequest();
            }

            Movie requestedMovie = await _repository.GetById(id);
            if (requestedMovie == null)
            {
                return NotFound();
            }
            await _repository.UpdateMovie(id, movie);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            Movie requestedMovie = await _repository.GetById(id);
            if (requestedMovie == null)
            {
                return NotFound();
            }
            await _repository.DeleteMovie(id);
            return NoContent();
        }
    }
}
