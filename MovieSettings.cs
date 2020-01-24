using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Models
{
    public class MovieSettings : IMovieSettings
    {
        public Stack<Movie> Movies { get; set; }
        public MovieSettings()
        {
            Movies = new Stack<Movie>();
        }
        public void Create(Movie movie)
        {
            Movies.Push(movie);
        }
        public List<Movie> Get()
        {
            List<Movie> temp = new List<Movie>();
            int cont = 1;
            foreach (var item in Movies)
            {
                temp.Add(Movies.Peek());
                cont++;
                if (cont > 10)
                {
                    break;
                }
            }
            return temp;
        }
    }
    public interface IMovieSettings
    {
        Stack<Movie> Movies { get; set; }
        void Create(Movie movie);
        List<Movie> Get();
    }
}
