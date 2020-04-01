using Proiect_TSPNET;
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
    public partial class AddItemSequence : Form
    {
        private readonly LocalItemsService service;
        public AddItemSequence(string path)
        {
            InitializeComponent();
            service = new LocalItemsService();
            this.label1.Text = path;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            service.AddLocalFile(this.label1.Text, this.Description.Text, this.ItemDate.Value, this.Overwrite.Checked);
            this.Close();
        }

    }
}
