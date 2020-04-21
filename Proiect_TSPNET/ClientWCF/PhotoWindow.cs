using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWCF
{
    public partial class PhotoWindow : Form
    {
        public PhotoWindow(string itemPath)
        {
            InitializeComponent();
            this.Picture.Image = new Bitmap(itemPath);
            this.Picture.Image = new Bitmap(this.Picture.Image, new Size(this.Picture.Width, this.Picture.Height));
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += OnPrinting;
            this.printDialog1.Document = doc;
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void OnPrinting(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(this.Picture.Image, new Rectangle(0, 0, this.Picture.Width, this.Picture.Height));
        }
    }
}
