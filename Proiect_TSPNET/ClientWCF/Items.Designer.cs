namespace ClientWCF
{
    partial class Items
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ItemsTable = new System.Windows.Forms.DataGridView();
            this.MfdCheck = new System.Windows.Forms.CheckBox();
            this.DeleteCheck = new System.Windows.Forms.CheckBox();
            this.Back = new System.Windows.Forms.Button();
            this.Attach = new System.Windows.Forms.Button();
            this.ViewRelated = new System.Windows.Forms.Button();
            this.MarkForDelete = new System.Windows.Forms.Button();
            this.PermaDelete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.AddFromFolder = new System.Windows.Forms.Button();
            this.ViewItem = new System.Windows.Forms.Button();
            this.mediaItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MoveItem = new System.Windows.Forms.Button();
            this.SelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.FilterProperties = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.SelectFile = new System.Windows.Forms.OpenFileDialog();
            this.FilterByRel = new System.Windows.Forms.Button();
            this.ViewInApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsTable
            // 
            this.ItemsTable.AllowUserToAddRows = false;
            this.ItemsTable.AllowUserToDeleteRows = false;
            this.ItemsTable.AllowUserToOrderColumns = true;
            this.ItemsTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsTable.GridColor = System.Drawing.SystemColors.HotTrack;
            this.ItemsTable.Location = new System.Drawing.Point(80, 50);
            this.ItemsTable.MultiSelect = false;
            this.ItemsTable.Name = "ItemsTable";
            this.ItemsTable.ReadOnly = true;
            this.ItemsTable.Size = new System.Drawing.Size(687, 320);
            this.ItemsTable.TabIndex = 0;
            // 
            // MfdCheck
            // 
            this.MfdCheck.AutoSize = true;
            this.MfdCheck.Location = new System.Drawing.Point(273, 12);
            this.MfdCheck.Name = "MfdCheck";
            this.MfdCheck.Size = new System.Drawing.Size(109, 17);
            this.MfdCheck.TabIndex = 1;
            this.MfdCheck.Text = "Marked for delete";
            this.MfdCheck.UseVisualStyleBackColor = true;
            this.MfdCheck.CheckedChanged += new System.EventHandler(this.MfdCheck_CheckedChanged);
            // 
            // DeleteCheck
            // 
            this.DeleteCheck.AutoSize = true;
            this.DeleteCheck.Location = new System.Drawing.Point(451, 12);
            this.DeleteCheck.Name = "DeleteCheck";
            this.DeleteCheck.Size = new System.Drawing.Size(63, 17);
            this.DeleteCheck.TabIndex = 2;
            this.DeleteCheck.Text = "Deleted";
            this.DeleteCheck.UseVisualStyleBackColor = true;
            this.DeleteCheck.CheckedChanged += new System.EventHandler(this.DeleteCheck_CheckedChanged);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(363, 546);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(113, 42);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Attach
            // 
            this.Attach.Location = new System.Drawing.Point(80, 404);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(75, 23);
            this.Attach.TabIndex = 4;
            this.Attach.Text = "Attach";
            this.Attach.UseVisualStyleBackColor = true;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // ViewRelated
            // 
            this.ViewRelated.Location = new System.Drawing.Point(182, 404);
            this.ViewRelated.Name = "ViewRelated";
            this.ViewRelated.Size = new System.Drawing.Size(102, 23);
            this.ViewRelated.TabIndex = 5;
            this.ViewRelated.Text = "View Related";
            this.ViewRelated.UseVisualStyleBackColor = true;
            this.ViewRelated.Click += new System.EventHandler(this.ViewRelated_Click);
            // 
            // MarkForDelete
            // 
            this.MarkForDelete.Location = new System.Drawing.Point(318, 404);
            this.MarkForDelete.Name = "MarkForDelete";
            this.MarkForDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MarkForDelete.Size = new System.Drawing.Size(130, 23);
            this.MarkForDelete.TabIndex = 6;
            this.MarkForDelete.Text = "Mark for delete";
            this.MarkForDelete.UseVisualStyleBackColor = true;
            this.MarkForDelete.Click += new System.EventHandler(this.MarkForDelete_Click);
            // 
            // PermaDelete
            // 
            this.PermaDelete.Location = new System.Drawing.Point(481, 404);
            this.PermaDelete.Name = "PermaDelete";
            this.PermaDelete.Size = new System.Drawing.Size(139, 23);
            this.PermaDelete.TabIndex = 7;
            this.PermaDelete.Text = "Delete marked items";
            this.PermaDelete.UseVisualStyleBackColor = true;
            this.PermaDelete.Click += new System.EventHandler(this.PermaDelete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(650, 404);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(117, 23);
            this.Edit.TabIndex = 8;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(80, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 9;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(80, 455);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(75, 23);
            this.AddItem.TabIndex = 10;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // AddFromFolder
            // 
            this.AddFromFolder.Location = new System.Drawing.Point(182, 455);
            this.AddFromFolder.Name = "AddFromFolder";
            this.AddFromFolder.Size = new System.Drawing.Size(102, 23);
            this.AddFromFolder.TabIndex = 11;
            this.AddFromFolder.Text = "Add all from folder";
            this.AddFromFolder.UseVisualStyleBackColor = true;
            this.AddFromFolder.Click += new System.EventHandler(this.AddFromFolder_Click);
            // 
            // ViewItem
            // 
            this.ViewItem.Location = new System.Drawing.Point(318, 455);
            this.ViewItem.Name = "ViewItem";
            this.ViewItem.Size = new System.Drawing.Size(130, 23);
            this.ViewItem.TabIndex = 12;
            this.ViewItem.Text = "View";
            this.ViewItem.UseVisualStyleBackColor = true;
            this.ViewItem.Click += new System.EventHandler(this.ViewItem_Click);
            // 
            // mediaItemsBindingSource
            // 
            this.mediaItemsBindingSource.DataSource = typeof(Proiect_TSPNET.MediaItemDTO);
            // 
            // MoveItem
            // 
            this.MoveItem.Location = new System.Drawing.Point(481, 454);
            this.MoveItem.Name = "MoveItem";
            this.MoveItem.Size = new System.Drawing.Size(139, 23);
            this.MoveItem.TabIndex = 13;
            this.MoveItem.Text = "Move";
            this.MoveItem.UseVisualStyleBackColor = true;
            this.MoveItem.Click += new System.EventHandler(this.MoveItem_Click);
            // 
            // FilterProperties
            // 
            this.FilterProperties.Location = new System.Drawing.Point(80, 500);
            this.FilterProperties.Name = "FilterProperties";
            this.FilterProperties.Size = new System.Drawing.Size(204, 23);
            this.FilterProperties.TabIndex = 14;
            this.FilterProperties.Text = "Filter by properties";
            this.FilterProperties.UseVisualStyleBackColor = true;
            this.FilterProperties.Click += new System.EventHandler(this.FilterProperties_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(650, 454);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(117, 23);
            this.Export.TabIndex = 15;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // SelectFile
            // 
            this.SelectFile.FileName = "SelectFile";
            // 
            // FilterByRel
            // 
            this.FilterByRel.Location = new System.Drawing.Point(318, 500);
            this.FilterByRel.Name = "FilterByRel";
            this.FilterByRel.Size = new System.Drawing.Size(204, 23);
            this.FilterByRel.TabIndex = 16;
            this.FilterByRel.Text = "Fileter by relations";
            this.FilterByRel.UseVisualStyleBackColor = true;
            this.FilterByRel.Click += new System.EventHandler(this.FilterByRel_Click);
            // 
            // ViewInApp
            // 
            this.ViewInApp.Location = new System.Drawing.Point(544, 499);
            this.ViewInApp.Name = "ViewInApp";
            this.ViewInApp.Size = new System.Drawing.Size(223, 23);
            this.ViewInApp.TabIndex = 17;
            this.ViewInApp.Text = "View in application";
            this.ViewInApp.UseVisualStyleBackColor = true;
            this.ViewInApp.Click += new System.EventHandler(this.ViewInApp_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 600);
            this.Controls.Add(this.ViewInApp);
            this.Controls.Add(this.FilterByRel);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.FilterProperties);
            this.Controls.Add(this.MoveItem);
            this.Controls.Add(this.ViewItem);
            this.Controls.Add(this.AddFromFolder);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.PermaDelete);
            this.Controls.Add(this.MarkForDelete);
            this.Controls.Add(this.ViewRelated);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DeleteCheck);
            this.Controls.Add(this.MfdCheck);
            this.Controls.Add(this.ItemsTable);
            this.Name = "Items";
            this.Text = "Items";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mediaItemsBindingSource;
        private System.Windows.Forms.DataGridView ItemsTable;
        private System.Windows.Forms.CheckBox MfdCheck;
        private System.Windows.Forms.CheckBox DeleteCheck;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Attach;
        private System.Windows.Forms.Button ViewRelated;
        private System.Windows.Forms.Button MarkForDelete;
        private System.Windows.Forms.Button PermaDelete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button AddFromFolder;
        private System.Windows.Forms.Button ViewItem;
        private System.Windows.Forms.Button MoveItem;
        private System.Windows.Forms.FolderBrowserDialog SelectFolder;
        private System.Windows.Forms.Button FilterProperties;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.OpenFileDialog SelectFile;
        private System.Windows.Forms.Button FilterByRel;
        private System.Windows.Forms.Button ViewInApp;
    }
}