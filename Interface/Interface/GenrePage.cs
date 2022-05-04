using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YLZ5155_Interface_1.Business;
using YLZ5155_Interface_1.Business.Repositories.Concrete;
using YLZ5155_Interface_1.Models.Entities.Concrete;

namespace YLZ5155_Interface_1
{
    public partial class GenrePage : Form
    {
        public GenrePage()
        {
            InitializeComponent();
        }

        GenreRepository genreRepository = new GenreRepository();

        private void GenrePage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = genreRepository.GetNotPassive();
        }

        private void btnCreateGenre_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.Name = txtCreateName.Text;
            genre.Id = genre.Name.ToLower();

            genreRepository.Create(genre);

            dataGridView1.DataSource = genreRepository.GetNotPassive();
            Utilities.Eraser(grpCreateGenre);
        }

        private void btnFind_Click(object sender, EventArgs e)
        { 
            Genre genre = genreRepository.GetById(txtFind.Text);

            txtUpdateName.Text = genre.Name;

            grpUpdate.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.Id = txtFind.Text;
            genre.Name = txtUpdateName.Text;

            genreRepository.Update(genre);

            dataGridView1.DataSource = genreRepository.GetNotPassive();

            Utilities.Eraser(grpFind);
            Utilities.Eraser(grpUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Genre genre = genreRepository.GetById(txtDelete.Text);
            genreRepository.Delete(genre);
            dataGridView1.DataSource = genreRepository.GetNotPassive();
            Utilities.Eraser(grpDelete);
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
             dataGridView1.DataSource = genreRepository.GetAll();

        }
    }
}
