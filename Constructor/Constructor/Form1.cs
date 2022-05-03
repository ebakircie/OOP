using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZL5155_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExample_1_Click(object sender, EventArgs e)
        {
            Car car_1 = new Car();
            car_1.Brand = "Ford";
            car_1.Model = "Mustang";
            car_1.EnginSize = "6.7";

            MessageBox.Show($"Brand: {car_1.Brand}\nModel: {car_1.Model}\nEngine Size: {car_1.EnginSize}");
        }

        private void btnExample_2_Click(object sender, EventArgs e)
        {
            Car car_2 = new Car("Volvo");
            car_2.Brand = "Dodge";
        }

        private void btnExample_3_Click(object sender, EventArgs e)
        {
            Car car_3 = new Car("Dodge", "Ram");
        }

        private void btnExample_4_Click(object sender, EventArgs e)
        {
            Car car_4 = new Car("Dodge", "Ram", "5.1");
        }
    }
}
