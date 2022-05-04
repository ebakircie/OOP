using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YLZ5155_Interface_1.Business.Repositories.Interface
{
    public interface IRepository<T>
    {
      //To show an example, we define another interface.

        List<T> GetByDefault();

    }
}
