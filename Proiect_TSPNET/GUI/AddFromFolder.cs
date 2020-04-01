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
    public partial class AddFromFolder : Form
    {
        private readonly LocalItemsService service;
        public AddFromFolder()
        {
            InitializeComponent();
            service = new LocalItemsService();
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            if (Select.ShowDialog() == DialogResult.OK)
            {
                this.CurrentFolder.Text = Select.SelectedPath;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (this.CurrentFolder.Text != string.Empty)
            {
                List<string> paths = service.GetAllMediaPathsFromFolder(this.CurrentFolder.Text, this.Recursive.Checked);
                foreach (string itemPath in paths)
                {
                    AddItemSequence addItem = new AddItemSequence(itemPath);
                    if (addItem.ShowDialog() != DialogResult.OK)
                    {

                    }
                }
            }
        }
    }
}
