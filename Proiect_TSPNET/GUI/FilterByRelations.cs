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
    public partial class FilterByRelations : Form
    {
        private readonly string[] types = { "People", "Locations", "Properties" };
        private readonly ItemsQueryService service;
        public List<MediaItemDTO> items;
        public FilterByRelations(List<MediaItemDTO> items)
        {
            InitializeComponent();
            service = new ItemsQueryService();
            this.RelationType.DataSource = this.types;
            this.RelationType.SelectedItem = this.types[0];
            this.items = items;
            UpdateDataGrid();

        }

        private void Types_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
        private void UpdateDataGrid()
        {
            string type = this.RelationType.SelectedItem.ToString();
            if (type == types[0])
            {
                var relations = service.GetPersons();
                this.RelationItems.DataSource = relations;

            }
            else if (type == types[1])
            {
                var relations = service.GetLocations();
                this.RelationItems.DataSource = relations;

            }
            else
            {
                var relations = service.GetProperties();
                this.RelationItems.DataSource = relations;

            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (this.RelationItems.CurrentRow.DataBoundItem != null)
            {
                string type = this.RelationType.SelectedItem.ToString();
                if (type == types[0])
                {
                    var person = (PersonDTO)this.RelationItems.CurrentRow.DataBoundItem;
                    items = service.FilterByRelation(items, person.FirstName, person.LastName, person.Group, type);

                }
                else if (type == types[1])
                {
                    var location = (LocationDTO)this.RelationItems.CurrentRow.DataBoundItem;
                    items = service.FilterByRelation(items, location.Name, location.Country, location.Region, type);

                }
                else
                {
                    var property = (PropertyDTO)this.RelationItems.CurrentRow.DataBoundItem;
                    items = service.FilterByRelation(items, property.Name, property.Value, string.Empty, type);
                }
                this.Close();
            }
        }
    }
}
