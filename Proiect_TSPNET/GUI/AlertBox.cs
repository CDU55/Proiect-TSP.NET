using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class AlertBox : Form
    {
        public static void DisplayMessage(string message)
        {
            AlertBox a = new AlertBox();
            a.message.Text = message;
            a.ShowDialog();
        }
        private AlertBox()
        {
            InitializeComponent();
        }

    }
}
