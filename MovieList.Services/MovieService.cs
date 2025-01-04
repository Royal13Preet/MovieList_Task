using MovieList.DataAccess.DBModel;
using MovieList.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.Services
{
    public class MovieService : IMovieService
    {
       
            private readonly IMovieRepo _repository;

            public MovieService(IMovieRepo repository)
            {
                _repository = repository;
            }

            public IEnumerable<Movie> GetAlltheMovieDetails(string name)
            {
                 
                var movies = _repository.GetAllMovies();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    movies = movies.Where(p => p.Title.Contains(name, StringComparison.OrdinalIgnoreCase));
                }
                return movies;

            }
            public Movie AddNewMovie(Movie movie)
            {
                var result = _repository.AddMovie(movie);
                return null;

            }
        }
    }


//public async Task<List<Movie>> GetMoviesAsync()
//{
//    var response = await _httpClient.GetStringAsync("https://raw.githubusercontent.com/prust/wikipedia-movie-data/master/movies.json");
//    return JsonConvert.DeserializeObject<List<Movie>>(response);
//}



