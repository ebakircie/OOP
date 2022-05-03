using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YZL5155_Abstract_3.Business.Repositories.Abstact;
using YZL5155_Abstract_3.Model.Entities.Concrete;
using YZL5155_Abstract_3.Model.Entities.Enums;

namespace YZL5155_Abstract_3.Business.Repositories.Concrete
{
    public class AppUserRepository : BaseRepository<AppUser>
    {
        public override void Create(AppUser entity)
        {
            FakeData.AppUsers.Add(entity);
        }

        public override void Delete(AppUser entity)
        {
            entity.Status = Status.Passive;
            entity.DeleteDate = DateTime.Now;
        }

        public override List<AppUser> GetAll()
        {
            List<AppUser> appUsers = FakeData.AppUsers.ToList();
            return appUsers;
        }

        public override AppUser GetById(int id)
        {
            AppUser findedAppUser = new AppUser();

            foreach (AppUser appUser in FakeData.AppUsers)
            {
                if (appUser.Id == id)
                {
                    findedAppUser = appUser;
                }
            }

            return findedAppUser;
        }

        public override List<AppUser> GetByLastName(string lastName)
        {
            List<AppUser> appUsers = new List<AppUser>();

            foreach (AppUser appUser in FakeData.AppUsers)
            {
                if (appUser.LastName == lastName)
                {
                    appUsers.Add(appUser);
                }
            }

            return appUsers;
        }

        public override List<AppUser> GetByRole(Role role)
        {
            List<AppUser> appUsers = new List<AppUser>();

            foreach (AppUser appUser in FakeData.AppUsers)
            {
                if (appUser.Role == role)
                {
                    appUsers.Add(appUser);
                }
            }

            return appUsers;
        }

        public override void Update(AppUser entity)
        {
            AppUser appUser = GetById(entity.Id);

            appUser.FirstName = entity.FirstName;
            appUser.LastName = entity.LastName;
            appUser.Role = entity.Role;
            appUser.Status = Status.Modified;
            appUser.UpdateDate = DateTime.Now;  
        }

        public override void GetRoles(ComboBox comboBox)
        {
            comboBox.Items.AddRange(Enum.GetNames(typeof(Role)));
            comboBox.SelectedIndex = 0;
        }
    }
}
