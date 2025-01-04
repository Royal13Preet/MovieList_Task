using Microsoft.EntityFrameworkCore;
using MovieList.DataAccess.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.DataAccess
{
    public class MovieDBContext : DbContext
    {
   
        public DbSet<Movie> Movies { get; set; }

        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(

                new Movie
                {
                    ID = 1,
                    Title = "After Dark in Central Park",
                    Year = new DateTime(2003,4,3),
                    Cast = null,
                    Genre = null,
                    ThumbLine = null
                });


            }
        }
    }


