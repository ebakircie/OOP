using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YZL5155_Abstract_3.Business.Repositories.Concrete;
using YZL5155_Abstract_3.Model.Entities.Concrete;
using YZL5155_Abstract_3.Model.Entities.Enums;

namespace YZL5155_Abstract_3
{
    public partial class AppUserPage : Form
    {
        public AppUserPage()
        {
            InitializeComponent();
        }

        AppUserRepository appUserRepository = new AppUserRepository();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AppUser appUser = new AppUser();
            appUser.Id = 4;
            appUser.FirstName = txtCreateFirstName.Text;
            appUser.LastName = txtCreateLastName.Text;
            appUser.Role = (Role)Enum.Parse(typeof(Role), cmbCreateRole.Text);

            appUserRepository.Create(appUser);

            dataGridView1.DataSource = appUserRepository.GetAll();
        }

        private void AppUserPage_Load(object sender, EventArgs e)
        {
            appUserRepository.GetRoles(cmbCreateRole);

            appUserRepository.GetRoles(cmbFindByRole);

            dataGridView1.DataSource = appUserRepository.GetAll();
        }

        int id;
        private void btnFind_Click(object sender, EventArgs e)
        {
            id = int.Parse(txtFindById.Text);
            AppUser appUser = appUserRepository.GetById(id);

            txtUpdateFirstName.Text = appUser.FirstName;
            txtUpdateLastName.Text = appUser.LastName;
            cmbUpdateRole.Text = appUser.Role.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AppUser appUser = new AppUser();
            appUser.Id = id;
            appUser.FirstName = txtUpdateFirstName.Text;
            appUser.LastName = txtUpdateLastName.Text;
            appUser.Role = (Role)Enum.Parse(typeof(Role), cmbUpdateRole.Text);

            appUserRepository.Update(appUser);

            dataGridView1.DataSource = appUserRepository.GetAll();
        }

        private void cmbUpdateRole_Click(object sender, EventArgs e)
        {
            appUserRepository.GetRoles(cmbUpdateRole);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDelete.Text);
            AppUser appUser = appUserRepository.GetById(id);
            appUserRepository.Delete(appUser);

            dataGridView1.DataSource = appUserRepository.GetAll();
        }

        private void btnFindByRole_Click(object sender, EventArgs e)
        {
            Role role = (Role)Enum.Parse(typeof(Role), cmbFindByRole.Text);
            List<AppUser> appUser = appUserRepository.GetByRole(role);
            dataGridView1.DataSource = appUser.ToList();
        }
    }
}
