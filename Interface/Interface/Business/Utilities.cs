using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YLZ5155_Interface_1.Business
{
    public static class Utilities
    {
        public static void Eraser (GroupBox groupBox)
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
