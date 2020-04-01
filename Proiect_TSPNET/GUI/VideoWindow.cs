using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class VideoWindow : Form
    {
        public VideoWindow(string videoPath)
        {
            InitializeComponent();
            this.VideoPlayer.URL = videoPath;
            this.VideoPlayer.Ctlcontrols.play();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.VideoPlayer.close();
            this.Close();
        }

    }
}
