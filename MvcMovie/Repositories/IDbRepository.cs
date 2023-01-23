using MvcMovie.Enums;
using MvcMovie.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcMovie.Repositories
{
    public interface IDbRepository
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieAsync(int? ID);
        Task CreateMovieAsync(Movie movie);
        Task<DbAnswer> EditAsync(Movie movie);
        Task<bool> MovieExistsAsync(int? ID);
        Task DeleteAsync(int ID);
        Task<MovieGenreViewModel> SearchAsync(string genre, string title);
    }
}
