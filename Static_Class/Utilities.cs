using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static_Class
{
    static class Utilities
    {
        //We cannot create an instance of static classes. We can reach them directly without instantiate the class. We can prefer them when we gonna use them in multiple places.They cannot be inherited or they cannot inherit from any class.

        //A helper to clean textboxes in form, we can call this method whenever we need without instantiate the class.
        public static void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = String.Empty;
                }
            }

        }

        public static string ComputerName = Environment.UserName + " " + Environment.MachineName;


    }
}
