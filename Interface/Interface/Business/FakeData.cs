using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YLZ5155_Interface_1.Models.Entities.Concrete;

namespace YLZ5155_Interface_1.Business
{
    public class FakeData
    {
        public static List<Genre> Genres = new List<Genre>()
        {
            new Genre {Id = "history", Name = "History"},
            new Genre {Id = "horror", Name = "Horror"},
            new Genre {Id = "scientific", Name = "Scientific"},
            new Genre {Id = "drama", Name = "Drama"},

        };

        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie {Id = 1, Title = "Interstellar", Description = "Best", Genre = Genres[2].Id},
            new Movie {Id = 2, Title = "Inception", Description = "Best", Genre = Genres[3].Id},
            new Movie {Id = 3, Title = "Fight Club", Description = "Best", Genre = Genres[1].Id}
        };
    }
}
