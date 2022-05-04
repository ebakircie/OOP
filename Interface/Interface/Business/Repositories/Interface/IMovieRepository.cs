using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YLZ5155_Interface_1.Models.Entities.Concrete;

namespace YLZ5155_Interface_1.Business.Repositories.Interface
{
    public interface IMovieRepository
    {
        List<Movie> GetByGenre(string genreName);
        Movie GetById(int id);
    }
}
