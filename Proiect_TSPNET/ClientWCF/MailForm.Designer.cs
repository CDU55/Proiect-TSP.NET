namespace ClientWCF
{
    partial class MailForm
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
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.SendToField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.SendTo = new System.Windows.Forms.Label();
            this.ServerType = new System.Windows.Forms.ComboBox();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameField
            // 
            this.UsernameField.Location = new System.Drawing.Point(140, 33);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(174, 20);
            this.UsernameField.TabIndex = 0;
            // 
            // SendToField
            // 
            this.SendToField.Location = new System.Drawing.Point(140, 159);
            this.SendToField.Name = "SendToField";
            this.SendToField.Size = new System.Drawing.Size(174, 20);
            this.SendToField.TabIndex = 1;
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(140, 97);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(174, 20);
            this.PasswordField.TabIndex = 2;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(181, 284);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(27, 33);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(83, 20);
            this.User.TabIndex = 4;
            this.User.Text = "Username";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(27, 97);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(78, 20);
            this.Pass.TabIndex = 5;
            this.Pass.Text = "Password";
            // 
            // SendTo
            // 
            this.SendTo.AutoSize = true;
            this.SendTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTo.Location = new System.Drawing.Point(27, 157);
            this.SendTo.Name = "SendTo";
            this.SendTo.Size = new System.Drawing.Size(69, 20);
            this.SendTo.TabIndex = 6;
            this.SendTo.Text = "Send To";
            // 
            // ServerType
            // 
            this.ServerType.FormattingEnabled = true;
            this.ServerType.Items.AddRange(new object[] {
            "GMAIL",
            "YAHOO"});
            this.ServerType.Location = new System.Drawing.Point(140, 218);
            this.ServerType.Name = "ServerType";
            this.ServerType.Size = new System.Drawing.Size(174, 21);
            this.ServerType.TabIndex = 7;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(136, 378);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 24);
            this.Message.TabIndex = 8;
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 467);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.ServerType);
            this.Controls.Add(this.SendTo);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.SendToField);
            this.Controls.Add(this.UsernameField);
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.TextBox SendToField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label SendTo;
        private System.Windows.Forms.ComboBox ServerType;
        private System.Windows.Forms.Label Message;
    }
}