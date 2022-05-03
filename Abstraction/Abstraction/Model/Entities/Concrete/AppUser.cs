
using YZL5155_Abstract_3.Model.Entities.Abstract;
using YZL5155_Abstract_3.Model.Entities.Enums;

namespace YZL5155_Abstract_3.Model.Entities.Concrete
{
    public class AppUser:BaseEntity<int>
    {
        public override int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string FullName => FirstName+" "+LastName;

        public Role Role { get; set; }
    }
}
