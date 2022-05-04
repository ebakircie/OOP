using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YLZ5155_Interface_1.Business.Repositories.Concrete;

namespace YLZ5155_Interface_1
{
    public partial class MoviePage : Form
    {
        public MoviePage()
        {
            InitializeComponent();
        }
        GenreRepository genreRepository = new GenreRepository();
        MovieRepository movieRepository = new MovieRepository();
        private void MoviePage_Load(object sender, EventArgs e)
        {
            cmbGetByGenre.DataSource = genreRepository.GetByDefault();
            cmbGetByGenre.DisplayMember = "Name"; // must be the same name with the member of Genre.cs
            cmbGetByGenre.ValueMember = "Id";
            cmbGetByGenre.SelectedIndex = 0;
        }

        private void btnGetByGenre_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = movieRepository.GetByGenre(cmbGetByGenre.Text.ToLower());
        }
    }
}
