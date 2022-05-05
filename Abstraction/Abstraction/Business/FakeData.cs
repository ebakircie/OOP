
using System.Collections.Generic;
using YZL5155_Abstract_3.Model.Entities.Concrete;
using YZL5155_Abstract_3.Model.Entities.Enums;

namespace YZL5155_Abstract_3.Business
{
    public static class FakeData
    {
        public static List<AppUser> AppUsers = new List<AppUser>()
        {
            new AppUser { Id = 1, FirstName = "Ersin", LastName = "Bakirci", Role = Role.Admin, UpdateDate = null, DeleteDate = null },
            new AppUser { Id = 2, FirstName = "Pazuzu", LastName = "zuzu", Role = Role.Admin, UpdateDate = null, DeleteDate = null },
            new AppUser { Id = 3, FirstName = "Ebb", LastName = "BBB", Role = Role.Member, UpdateDate = null, DeleteDate = null }
        };
    }
}
