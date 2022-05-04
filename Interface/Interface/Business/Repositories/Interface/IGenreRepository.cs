using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YLZ5155_Interface_1.Models.Entities.Concrete;

namespace YLZ5155_Interface_1.Business.Interface
{
    //as best practice we define first letter "I" when we use interface.
    public interface IGenreRepository
    {
        //All members written in the interface must be implemented by subclasses. So interfaces are rule makers. Interfaces and their members must be public otherwise it will give an error. Also logically it must be public to be overriden.
        
        //C# is not supporting multiple inheritance from classes, so we need interfaces for more inheritance.

        Genre GetById (string id);
    }
}
