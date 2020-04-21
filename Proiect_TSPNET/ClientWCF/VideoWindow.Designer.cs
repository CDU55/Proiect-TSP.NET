namespace ClientWCF
{
    partial class VideoWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoWindow));
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(22, 22);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(557, 349);
            this.VideoPlayer.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(234, 402);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(128, 37);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // VideoWindow
            // 
            this.ClientSize = new System.Drawing.Size(608, 464);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.VideoPlayer);
            this.Name = "VideoWindow";
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private System.Windows.Forms.Button Close;
    }
}