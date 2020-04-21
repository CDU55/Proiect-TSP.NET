namespace ClientWCF
{
    partial class FilterByRelations
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
            this.RelationItems = new System.Windows.Forms.DataGridView();
            this.RelationType = new System.Windows.Forms.ComboBox();
            this.Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RelationItems)).BeginInit();
            this.SuspendLayout();
            // 
            // RelationItems
            // 
            this.RelationItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RelationItems.Location = new System.Drawing.Point(222, 40);
            this.RelationItems.Name = "RelationItems";
            this.RelationItems.Size = new System.Drawing.Size(331, 183);
            this.RelationItems.TabIndex = 0;
            // 
            // RelationType
            // 
            this.RelationType.FormattingEnabled = true;
            this.RelationType.Location = new System.Drawing.Point(328, 254);
            this.RelationType.Name = "RelationType";
            this.RelationType.Size = new System.Drawing.Size(121, 21);
            this.RelationType.TabIndex = 1;
            this.RelationType.SelectedIndexChanged += new System.EventHandler(this.Types_SelectedIndexChanged);
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.Location = new System.Drawing.Point(328, 325);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(121, 60);
            this.Filter.TabIndex = 2;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // FilterByRelations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.RelationType);
            this.Controls.Add(this.RelationItems);
            this.Name = "FilterByRelations";
            this.Text = "FilterByRelations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterByRelations_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.RelationItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RelationItems;
        private System.Windows.Forms.ComboBox RelationType;
        private System.Windows.Forms.Button Filter;
    }
}