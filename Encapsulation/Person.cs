using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public class Person
    {
        private string _name;
        private int _age;
        public string Name { get => _name; set => _name = value; }
        public int Age 
        {
            get => _age;
            set 
            { 
                if (value < 18)
                {
                    _age = value;
                    MessageBox.Show("You cant enter!");
                }
                else
                {
                    _age = value;
                    MessageBox.Show("You can enter..");
                }
            } 
        }


    }
}
