using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YLZ5155_Interface_1.Business.Repositories.Abstract;
using YLZ5155_Interface_1.Business.Repositories.Interface;
using YLZ5155_Interface_1.Models.Entities.Abstract;
using YLZ5155_Interface_1.Models.Entities.Concrete;

namespace YLZ5155_Interface_1.Business.Repositories.Concrete
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public override void Create(Movie entity)
        {
            entity.CreatedBy = Utilities.ComputerName;
            FakeData.Movies.Add(entity);
        }

        public override void Delete(Movie entity)
        {
            entity.DeletedBy = Utilities.ComputerName;
            entity.Status = Status.Passive;
            entity.DeleteDate = DateTime.Now;
        }
        public override void Update(Movie entity)
        {
            Movie movie = GetById(entity.Id);
            movie.Title = entity.Title;
            movie.Description = entity.Description;
            movie.UpdateDate = DateTime.Now;
            movie.Status = Status.Modified;
            movie.ModifiedBy = Utilities.ComputerName;
        }

        public override List<Movie> GetAll()
        {
            return FakeData.Movies.ToList();
        }

        public List<Movie> GetByGenre(string genreName)
        {
            return FakeData.Movies.Where(x => x.Genre == genreName).ToList();
        }

        public Movie GetById(int id)
        {
            return FakeData.Movies.Where(x => x.Id == id).First();
        }

        public override List<Movie> GetNotPassive()
        {
            return FakeData.Movies.Where(x=> x.Status != Status.Passive).ToList();
        }

        
    }
}
