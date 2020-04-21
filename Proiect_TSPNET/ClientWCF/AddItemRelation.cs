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
    public partial class AddItemRelation : Form
    {
        private readonly string[] types = { "People", "Locations", "Properties" };
        private readonly ServiceClient service;
        private readonly string itemPath;
        private readonly List<string> messages = new List<string> { "Succes", "Already Added", "Already Removed" };
        public AddItemRelation(string itemPath)
        {
            InitializeComponent();
            service = new ServiceClient();
            this.itemPath = itemPath;
            this.RelationType.DataSource = types;
            this.RelationType.SelectedItem = types[0];
            UpdateDataGrid();

        }

        private void RelationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            string type = this.RelationType.SelectedItem.ToString();
            if (type == types[0])
            {
                var relations = service.GetPersons();
                this.dataGridView1.DataSource = relations;

            }
            else if (type == types[1])
            {
                var relations = service.GetLocations();
                this.dataGridView1.DataSource = relations;

            }
            else
            {
                var relations = service.GetProperties();
                this.dataGridView1.DataSource = relations;

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null)
            {
                this.label1.Text = string.Empty;
                string type = this.RelationType.SelectedItem.ToString();
                if (type == types[0])
                {
                    var person = (PersonDTO)this.dataGridView1.CurrentRow.DataBoundItem;
                    var isSuccesful = service.AttachPerson(this.itemPath, person.FirstName, person.LastName, person.Group);
                    if (isSuccesful)
                    {
                        this.label1.ForeColor = Color.DarkGreen;
                        this.label1.Text = messages[0];
                    }
                    else
                    {
                        this.label1.ForeColor = Color.DarkRed;
                        this.label1.Text = messages[1];
                    }
                }
                else if (type == types[1])
                {
                    var location = (LocationDTO)this.dataGridView1.CurrentRow.DataBoundItem;
                    var isSuccesful = service.ChangeLocation(this.itemPath, location.Name, location.Country, location.Region);
                    if (isSuccesful)
                    {
                        this.label1.ForeColor = Color.DarkGreen;
                        this.label1.Text = messages[0];
                    }
                    else
                    {
                        this.label1.ForeColor = Color.DarkRed;
                        this.label1.Text = messages[1];
                    }
                }
                else
                {
                    var property = (PropertyDTO)this.dataGridView1.CurrentRow.DataBoundItem;
                    var isSuccesful = service.AttachDynamicProperty(this.itemPath, property.Name, property.Value);
                    if (isSuccesful)
                    {
                        this.label1.ForeColor = Color.DarkGreen;
                        this.label1.Text = messages[0];
                    }
                    else
                    {
                        this.label1.ForeColor = Color.DarkRed;
                        this.label1.Text = messages[1];
                    }
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null)
            {
                string type = this.RelationType.SelectedItem.ToString();
                this.label1.Text = string.Empty;
                if (type == types[0])
                {
                    var person = (PersonDTO)this.dataGridView1.CurrentRow.DataBoundItem;
                    var isSuccesful = service.RemovePerson(this.itemPath, person.FirstName, person.LastName, person.Group);
                    if (isSuccesful)
                    {
                        this.label1.ForeColor = Color.DarkGreen;
                        this.label1.Text = messages[0];
                    }
                    else
                    {
                        this.label1.ForeColor = Color.DarkRed;
                        this.label1.Text = messages[2];
                    }
                }
                else if (type == types[1])
                {
                    var location = (LocationDTO)this.dataGridView1.CurrentRow.DataBoundItem;
                    var isSuccesful = service.RemoveLocation(this.itemPath);
                    if (isSuccesful)
                    {
                        this.label1.ForeColor = Color.DarkGreen;
                        this.label1.Text = messages[0];
                    }
                    else
                    {
                        this.label1.ForeColor = Color.DarkRed;
                        this.label1.Text = messages[2];
                    }
                }
                else
                {
                    var property = (PropertyDTO)this.dataGridView1.CurrentRow.DataBoundItem;
                    var isSuccesful = service.RemoveDynamicProperty(this.itemPath, property.Name, property.Value);
                    if (isSuccesful)
                    {
                        this.label1.ForeColor = Color.DarkGreen;
                        this.label1.Text = messages[0];
                    }
                    else
                    {
                        this.label1.ForeColor = Color.DarkRed;
                        this.label1.Text = messages[2];
                    }
                }
            }
        }

        private void AddItemRelation_FormClosing(object sender, FormClosingEventArgs e)
        {
            service.Close();
        }
    }
}
