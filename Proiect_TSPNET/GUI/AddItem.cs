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
    public partial class AddItem : Form
    {
        private readonly LocalItemsService service;
        public AddItem()
        {
            InitializeComponent();
            service = new LocalItemsService();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            if (this.OpenFile.ShowDialog() == DialogResult.OK)
            {
                this.FilePath.Text = OpenFile.FileName;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (this.FilePath.Text == string.Empty)
            {
                this.Result.Text = "Select a file Path";
            }
            else
            {
                var isSucces = service.AddLocalFile(this.FilePath.Text, this.richTextBox1.Text, this.ItemDate.Value, this.Overwrite.Checked);
                if (isSucces)
                {
                    this.Result.Text = "Succes";
                }
                else
                {
                    this.Result.Text = "Item already exists";
                }
            }
        }
    }
}
