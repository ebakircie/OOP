using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creating instance of a new Computer named hp. So we can reach properties of a class after creating it as an object and assign values to them. 
            Computer hp = new Computer();

            Computer samsung = new Computer(); // we can create as many as we want...

            hp.DisplaySecreen = true; // we only reach public properties.
            hp.MemoryType = "DDR5";
            hp.MemoryCapacity = 32;

            MessageBox.Show("Display: " + hp.DisplaySecreen + "\n" + "Memory Type: " + hp.MemoryType + "\n" + "Memory Capacity: " + hp.MemoryCapacity);
        }
    }
}
