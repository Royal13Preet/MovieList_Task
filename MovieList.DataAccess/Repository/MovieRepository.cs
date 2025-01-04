using MovieList.DataAccess.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.DataAccess.Repository
{
    public class MovieRepository : IMovieRepo
    {
        private readonly MovieDBContext _dbContext;

        public MovieRepository(MovieDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddMovie(Movie movie)
        {

            var res = _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            return true;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _dbContext.Movies;

        }
    }
}
