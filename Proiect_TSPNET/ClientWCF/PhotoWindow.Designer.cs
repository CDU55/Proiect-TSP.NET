namespace ClientWCF
{
    partial class PhotoWindow
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(12, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(776, 426);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Location = new System.Drawing.Point(341, 456);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(130, 49);
            this.PrintBtn.TabIndex = 1;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PhotoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.Picture);
            this.Name = "PhotoWindow";
            this.Text = "PhotoWindow";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}