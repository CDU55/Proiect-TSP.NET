using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_TSPNET;

namespace ClientWCF
{
    public partial class MailForm : Form
    {
        private readonly List<MediaItemDTO> items;
        public MailForm(List<MediaItemDTO> items)
        {
            InitializeComponent();
            this.items = items;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient;
                if (this.ServerType.SelectedItem.ToString() == "GMAIL")
                {
                    smtpClient = new SmtpClient("smtp.gmail.com");
                }
                else
                {
                    smtpClient = new SmtpClient("smtp.yahoo.com");
                }

                mail.From = new MailAddress(this.UsernameField.Text);
                mail.To.Add(this.SendToField.Text);
                mail.Subject = "[Query Result]";
                foreach (var item in this.items)
                {
                    mail.Body += "Path:" + item.Path + " " + "Title:" + item.Title + " " + "Extension:" + item.Extension +
                        " " + "Location" + item.Location + " " + "Event" + item.Event + "\n\n";
                }
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(this.UsernameField.Text, this.PasswordField.Text);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);
                this.Message.ForeColor = Color.Green;
                this.Message.Text = "Succes";
            }
            catch (Exception except)
            {
                this.Message.ForeColor = Color.Red;
                this.Message.Text = except.ToString();
            }
        }
    }
}
