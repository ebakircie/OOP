using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YLZ5155_Interface_1.Models.Entities.Abstract;

namespace YLZ5155_Interface_1.Models.Entities.Concrete
{
    public class Genre : BaseEntity<string>
    {
        public override string Id { get; set; }
        public string Name { get; set; }
       
    }
}
