namespace GUI
{
    partial class ItemsRelationsDisplay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowPeople = new System.Windows.Forms.Button();
            this.ShowProperties = new System.Windows.Forms.Button();
            this.ContentExists = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ShowPeople
            // 
            this.ShowPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPeople.Location = new System.Drawing.Point(93, 189);
            this.ShowPeople.Name = "ShowPeople";
            this.ShowPeople.Size = new System.Drawing.Size(126, 43);
            this.ShowPeople.TabIndex = 1;
            this.ShowPeople.Text = "People";
            this.ShowPeople.UseVisualStyleBackColor = true;
            this.ShowPeople.Click += new System.EventHandler(this.ShowPeople_Click);
            // 
            // ShowProperties
            // 
            this.ShowProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowProperties.Location = new System.Drawing.Point(264, 189);
            this.ShowProperties.Name = "ShowProperties";
            this.ShowProperties.Size = new System.Drawing.Size(126, 43);
            this.ShowProperties.TabIndex = 2;
            this.ShowProperties.Text = "Properties";
            this.ShowProperties.UseVisualStyleBackColor = true;
            this.ShowProperties.Click += new System.EventHandler(this.ShowProperties_Click);
            // 
            // ContentExists
            // 
            this.ContentExists.AutoSize = true;
            this.ContentExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentExists.ForeColor = System.Drawing.Color.DarkRed;
            this.ContentExists.Location = new System.Drawing.Point(195, 251);
            this.ContentExists.Name = "ContentExists";
            this.ContentExists.Size = new System.Drawing.Size(0, 20);
            this.ContentExists.TabIndex = 3;
            // 
            // ItemsRelationsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 295);
            this.Controls.Add(this.ContentExists);
            this.Controls.Add(this.ShowProperties);
            this.Controls.Add(this.ShowPeople);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ItemsRelationsDisplay";
            this.Text = "ItemsRelationsDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowPeople;
        private System.Windows.Forms.Button ShowProperties;
        private System.Windows.Forms.Label ContentExists;
    }
}