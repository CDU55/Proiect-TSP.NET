﻿namespace GUI
{
    partial class AlertBox
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
            this.message = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.ControlLight;
            this.message.Enabled = false;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(-2, 1);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(537, 400);
            this.message.TabIndex = 0;
            this.message.Text = "";
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 398);
            this.Controls.Add(this.message);
            this.Name = "AlertBox";
            this.Text = "AlertBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox message;
    }
}