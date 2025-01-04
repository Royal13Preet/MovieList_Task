using MovieList.DataAccess.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.Services
{
    public interface IMovieService
    {
        public IEnumerable<Movie> GetAlltheMovieDetails(string name);
        public Movie AddNewMovie(Movie movie);
    }
}
