using Proiect_TSPNET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClientWCF
{
    public partial class AddPeople : Form
    {
        private readonly List<string> groups = new List<string> { "Family", "Friends", "Collegues", "Celebrity", "Other" };
        private readonly ServiceClient service;
        public AddPeople()
        {
            InitializeComponent();
            this.comboBox1.DataSource = groups;
            this.comboBox1.SelectedItem = groups[0];
            this.service = new ServiceClient();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormOpener.Switch(this, new MainMenu());
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Result.Text = string.Empty;
            if (this.FirstName.Text == string.Empty)
            {
                this.Result.ForeColor = Color.DarkRed;
                this.Result.Text = "First name missing";
            }
            else if (this.LastName.Text == string.Empty)
            {
                this.Result.ForeColor = Color.DarkRed;
                this.Result.Text = "Last Name missing";
            }
            else
            {
                var succes = service.AddPerson(this.FirstName.Text, this.LastName.Text, this.comboBox1.SelectedItem.ToString());
                if (succes)
                {
                    this.Result.ForeColor = Color.DarkGreen;
                    this.Result.Text = "Succes";
                }
                else
                {
                    this.Result.ForeColor = Color.DarkRed;
                    this.Result.Text = "Person already exists";
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            this.Result.Text = string.Empty;
            if (this.FirstName.Text == string.Empty)
            {
                this.Result.ForeColor = Color.DarkRed;
                this.Result.Text = "First name missing";
            }
            else if (this.LastName.Text == string.Empty)
            {
                this.Result.ForeColor = Color.DarkRed;
                this.Result.Text = "Last Name missing";
            }
            else
            {
                var succes = service.RemovePersonFromContext(this.FirstName.Text, this.LastName.Text, this.comboBox1.SelectedItem.ToString());
                if (succes)
                {
                    this.Result.ForeColor = Color.DarkGreen;
                    this.Result.Text = "Succes";
                }
                else
                {
                    this.Result.ForeColor = Color.DarkRed;
                    this.Result.Text = "Entry does not exist";
                }
            }
        }
    }
}
