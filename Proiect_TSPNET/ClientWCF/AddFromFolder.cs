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

namespace ClientWCF
{
    public partial class AddFromFolder : Form
    {
        private readonly ServiceClient service;
        public AddFromFolder()
        {
            InitializeComponent();
            service = new ServiceClient();
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
                string[] paths = service.GetAllMediaPathsFromFolder(CurrentFolder.Text, this.Recursive.Checked);
                foreach (string itemPath in paths)
                {
                    AddItemSequence addItem = new AddItemSequence(itemPath);
                    if (addItem.ShowDialog() != DialogResult.OK)
                    {

                    }
                }
            }
        }

        private void AddFromFolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            service.Close();
        }
    }
}
