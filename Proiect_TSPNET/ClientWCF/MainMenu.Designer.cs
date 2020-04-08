namespace ClientWCF
{
    partial class MainMenu
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
            this.ViewItems = new System.Windows.Forms.Button();
            this.People = new System.Windows.Forms.Button();
            this.Locations = new System.Windows.Forms.Button();
            this.Properties = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewItems
            // 
            this.ViewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewItems.Location = new System.Drawing.Point(298, 38);
            this.ViewItems.Name = "ViewItems";
            this.ViewItems.Size = new System.Drawing.Size(219, 77);
            this.ViewItems.TabIndex = 0;
            this.ViewItems.Text = "View Items";
            this.ViewItems.UseVisualStyleBackColor = true;
            this.ViewItems.Click += new System.EventHandler(this.ViewItems_Click);
            // 
            // People
            // 
            this.People.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People.Location = new System.Drawing.Point(298, 135);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(219, 77);
            this.People.TabIndex = 1;
            this.People.Text = "People";
            this.People.UseVisualStyleBackColor = true;
            this.People.Click += new System.EventHandler(this.People_Click);
            // 
            // Locations
            // 
            this.Locations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locations.Location = new System.Drawing.Point(298, 231);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(219, 77);
            this.Locations.TabIndex = 2;
            this.Locations.Text = "Locations";
            this.Locations.UseVisualStyleBackColor = true;
            this.Locations.Click += new System.EventHandler(this.Locations_Click);
            // 
            // Properties
            // 
            this.Properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Properties.Location = new System.Drawing.Point(298, 327);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(219, 77);
            this.Properties.TabIndex = 3;
            this.Properties.Text = "Properties";
            this.Properties.UseVisualStyleBackColor = true;
            this.Properties.Click += new System.EventHandler(this.Properties_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Properties);
            this.Controls.Add(this.Locations);
            this.Controls.Add(this.People);
            this.Controls.Add(this.ViewItems);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewItems;
        private System.Windows.Forms.Button People;
        private System.Windows.Forms.Button Locations;
        private System.Windows.Forms.Button Properties;
    }
}