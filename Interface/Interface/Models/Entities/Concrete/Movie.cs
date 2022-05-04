using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YLZ5155_Interface_1.Models.Entities.Abstract;

namespace YLZ5155_Interface_1.Models.Entities.Concrete
{
    public class Movie : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
    }
}
