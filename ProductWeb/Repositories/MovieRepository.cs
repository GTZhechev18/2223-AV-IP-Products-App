using MinimalAuthAPI.Models
using ProductWeb.Services;

namespace ProductWeb.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public Movie Create(Movie movie) 
        {
            movie.Id = MovieRepository.Movies.Count + 1;
            MovieRepository.Movies.Add(movie);

            return movie;
        }

        public bool Delete(int id)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(a => a.Id == id);
            if (oldMovie != null) return false;

            MovieRepository.Movies.Remove(oldMovie);

            return true;
        }

        public Movie Get(int id) 
        {
            var movie = MovieRepository.Movies.FirstOrDefault(a => a.Id == id);
            if (movie != null) return false;

            MovieRepository.Movies
        }
    }
}
