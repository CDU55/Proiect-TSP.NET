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
    public partial class ItemsRelationsDisplay : Form
    {
        private readonly ItemsQueryService service;
        private readonly string itemPath;
        public ItemsRelationsDisplay(string itemPath)
        {
            InitializeComponent();
            this.service = new ItemsQueryService();
            this.itemPath = itemPath;
        }

        private void ShowPeople_Click(object sender, EventArgs e)
        {
            this.ContentExists.Text = string.Empty;
            List<PersonDTO> people = service.GetItemPersons(this.itemPath);
            if (people.Count > 0)
            {
                this.dataGridView1.DataSource = people;
            }
            else
            {
                this.dataGridView1.DataSource = new List<PersonDTO>();
                this.ContentExists.Text = "No Content";
            }
        }

        private void ShowProperties_Click(object sender, EventArgs e)
        {
            this.ContentExists.Text = string.Empty;
            List<PropertyDTO> properties = service.GetItemDynamicProperties(this.itemPath);
            if (properties.Count > 0)
            {
                this.dataGridView1.DataSource = properties;
            }
            else
            {
                this.dataGridView1.DataSource = new List<PropertyDTO>();
                this.ContentExists.Text = "No Content";
            }
        }
    }
}
