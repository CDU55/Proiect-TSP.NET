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
    public partial class AddProperties : Form
    {
        private ServiceClient service;
        public AddProperties()
        {
            InitializeComponent();
            service = new ServiceClient();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.label3.Text = string.Empty;
            if (this.Name.Text == string.Empty)
            {
                this.label3.ForeColor = Color.DarkRed;
                this.label3.Text = "Name missing";
            }
            else if (this.Value.Text == string.Empty)
            {
                this.label3.ForeColor = Color.DarkRed;
                this.label3.Text = "Value missing";
            }
            else
            {
                var isSuccesful = service.AddDynamicPropery(Name.Text, Value.Text);
                if (!isSuccesful)
                {
                    this.label3.ForeColor = Color.DarkRed;
                    this.label3.Text = "Already exists";
                }
                else
                {
                    this.label3.ForeColor = Color.DarkGreen;
                    this.label3.Text = "Succes";
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormOpener.Switch(this, new MainMenu());
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            this.label3.Text = string.Empty;
            if (this.Name.Text == string.Empty)
            {
                this.label3.ForeColor = Color.DarkRed;
                this.label3.Text = "Name missing";
            }
            else if (this.Value.Text == string.Empty)
            {
                this.label3.ForeColor = Color.DarkRed;
                this.label3.Text = "Value missing";
            }
            else
            {
                var isSuccesful = service.RemovePropertyFromContext(Name.Text, Value.Text);
                if (!isSuccesful)
                {
                    this.label3.ForeColor = Color.DarkRed;
                    this.label3.Text = "Entry does not exist";
                }
                else
                {
                    this.label3.ForeColor = Color.DarkGreen;
                    this.label3.Text = "Succes";
                }
            }
        }


    }
}
