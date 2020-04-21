namespace ClientWCF
{
    partial class AddItem
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
            this.SelectFile = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Overwrite = new System.Windows.Forms.CheckBox();
            this.ItemDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(401, 81);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(75, 23);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePath.Location = new System.Drawing.Point(54, 29);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(0, 20);
            this.FilePath.TabIndex = 1;
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "ofd";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(58, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(418, 194);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(220, 503);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.DarkGreen;
            this.Result.Location = new System.Drawing.Point(171, 542);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 24);
            this.Result.TabIndex = 4;
            // 
            // Overwrite
            // 
            this.Overwrite.AutoSize = true;
            this.Overwrite.Location = new System.Drawing.Point(220, 467);
            this.Overwrite.Name = "Overwrite";
            this.Overwrite.Size = new System.Drawing.Size(71, 17);
            this.Overwrite.TabIndex = 5;
            this.Overwrite.Text = "Overwrite";
            this.Overwrite.UseVisualStyleBackColor = true;
            // 
            // ItemDate
            // 
            this.ItemDate.Location = new System.Drawing.Point(155, 420);
            this.ItemDate.Name = "ItemDate";
            this.ItemDate.Size = new System.Drawing.Size(200, 20);
            this.ItemDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemDate);
            this.Controls.Add(this.Overwrite);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.SelectFile);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddItem_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.CheckBox Overwrite;
        private System.Windows.Forms.DateTimePicker ItemDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}