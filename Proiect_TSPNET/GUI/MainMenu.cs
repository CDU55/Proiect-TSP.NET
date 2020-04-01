using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ViewItems_Click(object sender, EventArgs e)
        {
            FormOpener.Switch(this, new Items());
        }

        private void People_Click(object sender, EventArgs e)
        {
            FormOpener.Switch(this, new AddPeople());
        }

        private void Properties_Click(object sender, EventArgs e)
        {
            FormOpener.Switch(this, new AddProperties());
        }

        private void Locations_Click(object sender, EventArgs e)
        {
            FormOpener.Switch(this, new Add_Locations());
        }
    }
}
