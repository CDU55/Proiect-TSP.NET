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
    public partial class PhotoWindow : Form
    {
        public PhotoWindow(string itemPath)
        {
            InitializeComponent();
            this.Picture.Image = new Bitmap(itemPath);
            this.Picture.Image = new Bitmap(this.Picture.Image, new Size(this.Picture.Width, this.Picture.Height));
        }
    }
}
