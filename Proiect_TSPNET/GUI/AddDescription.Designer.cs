namespace GUI
{
    partial class AddDescription
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Event = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.DateCheck = new System.Windows.Forms.CheckBox();
            this.EventCheck = new System.Windows.Forms.CheckBox();
            this.DescriptionCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(155, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 205);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(238, 322);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(234, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // Event
            // 
            this.Event.Location = new System.Drawing.Point(238, 236);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(100, 20);
            this.Event.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(182, 282);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 4;
            // 
            // DateCheck
            // 
            this.DateCheck.AutoSize = true;
            this.DateCheck.Location = new System.Drawing.Point(28, 287);
            this.DateCheck.Name = "DateCheck";
            this.DateCheck.Size = new System.Drawing.Size(49, 17);
            this.DateCheck.TabIndex = 5;
            this.DateCheck.Text = "Date";
            this.DateCheck.UseVisualStyleBackColor = true;
            // 
            // EventCheck
            // 
            this.EventCheck.AutoSize = true;
            this.EventCheck.Location = new System.Drawing.Point(28, 239);
            this.EventCheck.Name = "EventCheck";
            this.EventCheck.Size = new System.Drawing.Size(54, 17);
            this.EventCheck.TabIndex = 6;
            this.EventCheck.Text = "Event";
            this.EventCheck.UseVisualStyleBackColor = true;
            // 
            // DescriptionCheck
            // 
            this.DescriptionCheck.AutoSize = true;
            this.DescriptionCheck.Location = new System.Drawing.Point(28, 111);
            this.DescriptionCheck.Name = "DescriptionCheck";
            this.DescriptionCheck.Size = new System.Drawing.Size(79, 17);
            this.DescriptionCheck.TabIndex = 7;
            this.DescriptionCheck.Text = "Description";
            this.DescriptionCheck.UseVisualStyleBackColor = true;
            // 
            // AddDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 410);
            this.Controls.Add(this.DescriptionCheck);
            this.Controls.Add(this.EventCheck);
            this.Controls.Add(this.DateCheck);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AddDescription";
            this.Text = "AddDescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Event;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.CheckBox DateCheck;
        private System.Windows.Forms.CheckBox EventCheck;
        private System.Windows.Forms.CheckBox DescriptionCheck;
    }
}