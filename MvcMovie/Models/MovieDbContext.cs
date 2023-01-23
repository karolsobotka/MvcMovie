using Microsoft.EntityFrameworkCore;
using MvcMovie.EntityTypeConfigurations;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MvcMovie.Models
{
    public class MovieDbContex : DbContext
    {
        public MovieDbContex() { }
        public MovieDbContex(DbContextOptions<MovieDbContex> options) : base(options) { }

        public virtual DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieEntityTypeConfiguration());
        }
    }
}
