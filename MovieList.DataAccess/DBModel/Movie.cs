using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.DataAccess.DBModel
{
    public class Movie
    {
        public int ID { get; set; } 

        public string Title { get; set; }

        public DateTime Year { get; set; }

        public string? Cast {  get; set; }

        public string? Genre { get; set; }

        public string? ThumbLine { get; set; }
    }
}
