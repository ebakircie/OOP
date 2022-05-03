
using System.Collections.Generic;
using System.Windows.Forms;
using YZL5155_Abstract_3.Model.Entities.Enums;

namespace YZL5155_Abstract_3.Business.Repositories.Abstact
{
    public abstract class BaseRepository<T> 
    {
        public abstract void Create(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);

        public abstract List<T> GetAll();

        public abstract T GetById(int id);
        public abstract List<T> GetByRole(Role role);
        public abstract List<T> GetByLastName(string lastName);

        public abstract void GetRoles(ComboBox comboBox);
    }
}
