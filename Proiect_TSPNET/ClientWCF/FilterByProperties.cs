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
    public partial class FilterByProperties : Form
    {
        public List<MediaItemDTO> items;
        private readonly ServiceClient service;
        public FilterByProperties(List<MediaItemDTO> items)
        {
            InitializeComponent();
            this.items = items;
            this.service = new ServiceClient();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            this.items = service.FileterByScalar(items.ToArray(), Extension.Text, ExtensionCheck.Checked, Date.Value, DateCheck.Checked, IsPhoto.Checked, IsPhotoCheck.Checked, EventName.Text, EventCheck.Checked).ToList();
            this.Close();
        }
    }
}
