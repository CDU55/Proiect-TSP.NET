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
    public partial class FilterByProperties : Form
    {
        public List<MediaItemDTO> items;
        private readonly ItemsQueryService service;
        public FilterByProperties(List<MediaItemDTO> items)
        {
            InitializeComponent();
            this.items = items;
            this.service = new ItemsQueryService();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            this.items=service.FileterByScalar(items, Extension.Text, ExtensionCheck.Checked, Date.Value, DateCheck.Checked, IsPhoto.Checked, IsPhotoCheck.Checked, EventName.Text, EventCheck.Checked);
            this.Close();
        }
    }
}
