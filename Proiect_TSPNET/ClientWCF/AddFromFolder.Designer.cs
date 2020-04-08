namespace ClientWCF
{
    partial class AddFromFolder
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
            this.CurrentFolder = new System.Windows.Forms.Label();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.FolderBrowserDialog();
            this.Add = new System.Windows.Forms.Button();
            this.Recursive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CurrentFolder
            // 
            this.CurrentFolder.AutoSize = true;
            this.CurrentFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentFolder.Location = new System.Drawing.Point(12, 25);
            this.CurrentFolder.Name = "CurrentFolder";
            this.CurrentFolder.Size = new System.Drawing.Size(0, 16);
            this.CurrentFolder.TabIndex = 0;
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(201, 100);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(96, 23);
            this.SelectFolder.TabIndex = 1;
            this.SelectFolder.Text = "Select Folder";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(201, 146);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(96, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Recursive
            // 
            this.Recursive.AutoSize = true;
            this.Recursive.Location = new System.Drawing.Point(223, 194);
            this.Recursive.Name = "Recursive";
            this.Recursive.Size = new System.Drawing.Size(74, 17);
            this.Recursive.TabIndex = 4;
            this.Recursive.Text = "Recursive";
            this.Recursive.UseVisualStyleBackColor = true;
            // 
            // AddFromFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 259);
            this.Controls.Add(this.Recursive);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.CurrentFolder);
            this.Name = "AddFromFolder";
            this.Text = "AddFromFolder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentFolder;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.FolderBrowserDialog Select;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.CheckBox Recursive;
    }
}