using Inheritance.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = 1;
            category.Name = "Accessories";

            Product product = new Product();
            product.Id = 1;
            product.Name = "Mouse";
            product.Stock = 10;
            product.Description = "Best mouse ever!";
            product.Price = 70;
            
        }
    }
}
