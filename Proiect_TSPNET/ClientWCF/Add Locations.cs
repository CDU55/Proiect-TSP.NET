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
    public partial class Add_Locations : Form
    {
        private readonly ServiceClient service;

        public Add_Locations()
        {
            InitializeComponent();
            this.service = new ServiceClient();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.label4.Text = string.Empty;
            if (this.textBox1.Text == string.Empty)
            {
                this.label4.ForeColor = Color.DarkRed;
                this.label4.Text = "Name missing";
            }
            else if (this.textBox2.Text == string.Empty)
            {
                this.label4.ForeColor = Color.DarkRed;
                this.label4.Text = "Country missing";
            }
            else if (this.textBox3.Text == string.Empty)
            {
                this.label4.ForeColor = Color.DarkRed;
                this.label4.Text = "Region missing";
            }
            else
            {
                var isSuccesful = this.service.AddLocation(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text);
                if (!isSuccesful)
                {
                    this.label4.ForeColor = Color.DarkRed;
                    this.label4.Text = "Already Exists";
                }
                else
                {
                    this.label4.ForeColor = Color.DarkGreen;
                    this.label4.Text = "Succes";
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormOpener.Switch(this, new MainMenu());
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            this.label4.Text = string.Empty;
            if (this.textBox1.Text == string.Empty)
            {
                this.label4.ForeColor = Color.DarkRed;
                this.label4.Text = "Name missing";
            }
            else if (this.textBox2.Text == string.Empty)
            {
                this.label4.ForeColor = Color.DarkRed;
                this.label4.Text = "Country missing";
            }
            else if (this.textBox3.Text == string.Empty)
            {
                this.label4.ForeColor = Color.DarkRed;
                this.label4.Text = "Region missing";
            }
            else
            {
                var isSuccesful = this.service.RemoveLocationFromContext(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text);
                if (!isSuccesful)
                {
                    this.label4.ForeColor = Color.DarkRed;
                    this.label4.Text = "Location does not exist";
                }
                else
                {
                    this.label4.ForeColor = Color.DarkGreen;
                    this.label4.Text = "Succes";
                }
            }
        }
    }
}
