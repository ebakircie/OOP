using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YLZ5155_Interface_1.Business.Repositories.Abstract
{
    public abstract class BaseRepository<T>
    {
       //We define all CRUD methods here which will be used by entities. 
        public abstract void Create(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);

        //Get

        public abstract List<T> GetAll();
        public abstract List<T> GetNotPassive();
    }
}
