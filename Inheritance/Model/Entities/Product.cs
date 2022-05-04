using Inheritance.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model.Entities
{
    public class Product:BaseEntity
    {
        //Although it inherits objects from base class, sub classes can contain their own specific objects
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public string Description { get; set; }
    }
}
