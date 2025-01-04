using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieList.DataAccess.DBModel;
using MovieList.Services;

namespace MovieList.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("Create-Movie")]
        public IActionResult CreateMovie(Movie movie)
        {
            var createdProduct = _movieService.AddNewMovie(movie);
            return StatusCode(201, new {movie = createdProduct});
        }

        [HttpGet("Get-Movie-with-Typed-Title")]
        public IActionResult GetProducts( string? name = null)
        {
            var result = _movieService.GetAlltheMovieDetails(name);
            return Ok(result);
        }

    }
}
