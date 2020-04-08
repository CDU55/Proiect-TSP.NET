using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWCF
{
    public class FormOpener
    {
        public static void Switch(Form caller, Form toOpen)
        {
            caller.Hide();
            toOpen.ShowDialog();
            caller.Close();
        }
        public static void Open(Form toOpen)
        {
            toOpen.Show();
        }
    }
}
