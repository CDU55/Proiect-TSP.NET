namespace ClientWCF
{
    partial class FilterByProperties
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
            this.ExtensionCheck = new System.Windows.Forms.CheckBox();
            this.EventCheck = new System.Windows.Forms.CheckBox();
            this.IsPhotoCheck = new System.Windows.Forms.CheckBox();
            this.DateCheck = new System.Windows.Forms.CheckBox();
            this.Extension = new System.Windows.Forms.TextBox();
            this.EventName = new System.Windows.Forms.TextBox();
            this.IsPhoto = new System.Windows.Forms.CheckBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Filter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExtensionCheck
            // 
            this.ExtensionCheck.AutoSize = true;
            this.ExtensionCheck.Location = new System.Drawing.Point(84, 65);
            this.ExtensionCheck.Name = "ExtensionCheck";
            this.ExtensionCheck.Size = new System.Drawing.Size(72, 17);
            this.ExtensionCheck.TabIndex = 0;
            this.ExtensionCheck.Text = "Extension";
            this.ExtensionCheck.UseVisualStyleBackColor = true;
            // 
            // EventCheck
            // 
            this.EventCheck.AutoSize = true;
            this.EventCheck.Location = new System.Drawing.Point(84, 208);
            this.EventCheck.Name = "EventCheck";
            this.EventCheck.Size = new System.Drawing.Size(54, 17);
            this.EventCheck.TabIndex = 1;
            this.EventCheck.Text = "Event";
            this.EventCheck.UseVisualStyleBackColor = true;
            // 
            // IsPhotoCheck
            // 
            this.IsPhotoCheck.AutoSize = true;
            this.IsPhotoCheck.Location = new System.Drawing.Point(84, 163);
            this.IsPhotoCheck.Name = "IsPhotoCheck";
            this.IsPhotoCheck.Size = new System.Drawing.Size(86, 17);
            this.IsPhotoCheck.TabIndex = 2;
            this.IsPhotoCheck.Text = "Photo/Video";
            this.IsPhotoCheck.UseVisualStyleBackColor = true;
            // 
            // DateCheck
            // 
            this.DateCheck.AutoSize = true;
            this.DateCheck.Location = new System.Drawing.Point(84, 110);
            this.DateCheck.Name = "DateCheck";
            this.DateCheck.Size = new System.Drawing.Size(49, 17);
            this.DateCheck.TabIndex = 3;
            this.DateCheck.Text = "Date";
            this.DateCheck.UseVisualStyleBackColor = true;
            // 
            // Extension
            // 
            this.Extension.Location = new System.Drawing.Point(213, 65);
            this.Extension.Name = "Extension";
            this.Extension.Size = new System.Drawing.Size(100, 20);
            this.Extension.TabIndex = 4;
            // 
            // EventName
            // 
            this.EventName.Location = new System.Drawing.Point(213, 208);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(100, 20);
            this.EventName.TabIndex = 5;
            // 
            // IsPhoto
            // 
            this.IsPhoto.AutoSize = true;
            this.IsPhoto.Location = new System.Drawing.Point(213, 163);
            this.IsPhoto.Name = "IsPhoto";
            this.IsPhoto.Size = new System.Drawing.Size(54, 17);
            this.IsPhoto.TabIndex = 6;
            this.IsPhoto.Text = "Photo";
            this.IsPhoto.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(213, 110);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 7;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(150, 281);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(75, 23);
            this.Filter.TabIndex = 8;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // FilterByProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.IsPhoto);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.Extension);
            this.Controls.Add(this.DateCheck);
            this.Controls.Add(this.IsPhotoCheck);
            this.Controls.Add(this.EventCheck);
            this.Controls.Add(this.ExtensionCheck);
            this.Name = "FilterByProperties";
            this.Text = "FilterByProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ExtensionCheck;
        private System.Windows.Forms.CheckBox EventCheck;
        private System.Windows.Forms.CheckBox IsPhotoCheck;
        private System.Windows.Forms.CheckBox DateCheck;
        private System.Windows.Forms.TextBox Extension;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.CheckBox IsPhoto;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button Filter;
    }
}