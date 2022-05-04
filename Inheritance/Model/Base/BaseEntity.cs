using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model.Base
{
    // Base class will be inherited by sub classes
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
