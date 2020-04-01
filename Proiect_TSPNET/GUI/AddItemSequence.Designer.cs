namespace GUI
{
    partial class AddItemSequence
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
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Overwrite = new System.Windows.Forms.CheckBox();
            this.Add = new System.Windows.Forms.Button();
            this.ItemDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(59, 117);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(312, 153);
            this.Description.TabIndex = 1;
            this.Description.Text = "";
            // 
            // Overwrite
            // 
            this.Overwrite.AutoSize = true;
            this.Overwrite.Location = new System.Drawing.Point(170, 408);
            this.Overwrite.Name = "Overwrite";
            this.Overwrite.Size = new System.Drawing.Size(71, 17);
            this.Overwrite.TabIndex = 2;
            this.Overwrite.Text = "Overwrite";
            this.Overwrite.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(170, 458);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ItemDate
            // 
            this.ItemDate.Location = new System.Drawing.Point(114, 352);
            this.ItemDate.Name = "ItemDate";
            this.ItemDate.Size = new System.Drawing.Size(200, 20);
            this.ItemDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(151, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(180, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // AddItemSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemDate);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Overwrite);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Name = "AddItemSequence";
            this.Text = "AddItemSequence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.CheckBox Overwrite;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DateTimePicker ItemDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}