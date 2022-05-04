using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YLZ5155_Interface_1.Business.Interface;
using YLZ5155_Interface_1.Business.Repositories.Abstract;
using YLZ5155_Interface_1.Business.Repositories.Interface;
using YLZ5155_Interface_1.Models.Entities.Abstract;
using YLZ5155_Interface_1.Models.Entities.Concrete;

namespace YLZ5155_Interface_1.Business.Repositories.Concrete
{
    public class GenreRepository : BaseRepository<Genre>,IGenreRepository,IRepository<Genre>
    {
        //as C# is not supporting multiple inheritance from classes, so we inherit from interfaces as many as we want.

        //in this example GenreRepository inherit BaseRepository as a base class, which means it can't inherit another classes so we use interfaces to make multiple inheritance.                                      
        public override void Create(Genre entity)
        {
            entity.CreatedBy = Utilities.ComputerName;
            FakeData.Genres.Add(entity);
        }

        public override void Delete(Genre entity)
        {
            entity.Status = Models.Entities.Abstract.Status.Passive;
            entity.DeleteDate = DateTime.Now;
            entity.DeletedBy = Utilities.ComputerName;
        }

        public override List<Genre> GetAll()
        {
            return FakeData.Genres.ToList();
        }

       

        public Genre GetById(string id)
        {
            // with the help of System.Linq we can write SQL like querries to the collections.

            
            Genre genre = FakeData.Genres.Where(x => x.Id == id).First();
            return genre;
        }

        public override void Update(Genre entity)
        {
            Genre genre = GetById(entity.Id);

            genre.Id = entity.Name.ToLower();
            genre.Name = entity.Name;
            genre.Status = Status.Modified;
            genre.UpdateDate = DateTime.Now;
            genre.ModifiedBy = Utilities.ComputerName;
        }
        public override List<Genre> GetNotPassive()
        {
            return FakeData.Genres.Where(x=> x.Status != Status.Passive).ToList();
        }

        public List<Genre> GetByDefault()
        {
            return FakeData.Genres.Where(x => x.Status != Status.Passive).ToList();
        }
    }
}
