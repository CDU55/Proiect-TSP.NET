using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWCF
{
    public partial class AddDescription : Form
    {
        private readonly ServiceClient service;
        private readonly string currentItemPath;
        public AddDescription(string path)
        {
            InitializeComponent();
            service = new ServiceClient();
            currentItemPath = path;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
            var isSucces = service.EditItem(currentItemPath, this.richTextBox1.Text, this.DescriptionCheck.Checked, this.Event.Text, this.EventCheck.Checked,
                this.Date.Value, this.DateCheck.Checked);
            if (isSucces)
            {
                this.label1.ForeColor = Color.Green;
                this.label1.Text = "Item edited";
            }
            else
            {
                this.label1.ForeColor = Color.Red;
                this.label1.Text = "Fail";
            }
        }

    }
}
