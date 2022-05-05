using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YZL5155_Polymorphism.Entities.Concrete;
using YZL5155_Polymorphism.Repositories.Concrete;

namespace YZL5155_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNokia_Click(object sender, EventArgs e)
        {
            Nokia nokia = new Nokia()
            {
                Id = 1,
                Brand = "Nokia",
                Model = "3310",
                Price = "34"
            };

            NokiaRepository nokiaRepository = new NokiaRepository();

            nokiaRepository.CallSound();

            MessageBox.Show($"Brand: {nokia.Brand}\nModel: {nokia.Model}\nPrice: {nokia.Price}");
        }

        private void btnSamsung_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.Id = 1;
            samsung.Brand = "Samsung";
            samsung.Price = "50";

            SamsungRepository samsungRepository = new SamsungRepository();
            samsungRepository.CallSound();

            MessageBox.Show($"Brand: {samsung.Brand}\nModel: {samsung.Model}\nPrice: {samsung.Price}");
        }

        private void btnIphone_Click(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone()
            {
                Id = 1,
                Brand = "Iphone",
                Model = "x13",
                Price = "80"
            };

            IphoneRepository iphoneRepository = new IphoneRepository();
            iphoneRepository.CallSound();

            MessageBox.Show($"Brand: {iphone.Brand}\nModel: {iphone.Model}\nPrice: {iphone.Price}");
        }
    }
}
