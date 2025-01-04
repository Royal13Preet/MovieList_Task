using MovieList.DataAccess.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.DataAccess.Repository
{
    public interface IMovieRepo
    {
        public bool AddMovie(Movie movie);
        public IEnumerable<Movie> GetAllMovies();
    }
}
