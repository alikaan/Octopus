namespace Octopus
{
    partial class LoginForm
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
            this.UsernameMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UsernameMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginMetroButton = new MetroFramework.Controls.MetroButton();
            this.RememberMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.NewToOctopusMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.CreateAccountMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // UsernameMetroTextBox
            // 
            this.UsernameMetroTextBox.Location = new System.Drawing.Point(134, 81);
            this.UsernameMetroTextBox.Name = "UsernameMetroTextBox";
            this.UsernameMetroTextBox.Size = new System.Drawing.Size(121, 23);
            this.UsernameMetroTextBox.TabIndex = 0;
            // 
            // UsernameMetroLabel
            // 
            this.UsernameMetroLabel.AutoSize = true;
            this.UsernameMetroLabel.Location = new System.Drawing.Point(33, 81);
            this.UsernameMetroLabel.Name = "UsernameMetroLabel";
            this.UsernameMetroLabel.Size = new System.Drawing.Size(75, 19);
            this.UsernameMetroLabel.TabIndex = 1;
            this.UsernameMetroLabel.Text = "Username :";
            // 
            // PasswordMetroLabel
            // 
            this.PasswordMetroLabel.AutoSize = true;
            this.PasswordMetroLabel.Location = new System.Drawing.Point(33, 114);
            this.PasswordMetroLabel.Name = "PasswordMetroLabel";
            this.PasswordMetroLabel.Size = new System.Drawing.Size(70, 19);
            this.PasswordMetroLabel.TabIndex = 2;
            this.PasswordMetroLabel.Text = "Password :";
            // 
            // PasswordMetroTextBox
            // 
            this.PasswordMetroTextBox.Location = new System.Drawing.Point(134, 114);
            this.PasswordMetroTextBox.Name = "PasswordMetroTextBox";
            this.PasswordMetroTextBox.Size = new System.Drawing.Size(121, 23);
            this.PasswordMetroTextBox.TabIndex = 3;
            // 
            // LoginMetroButton
            // 
            this.LoginMetroButton.Location = new System.Drawing.Point(286, 114);
            this.LoginMetroButton.Name = "LoginMetroButton";
            this.LoginMetroButton.Size = new System.Drawing.Size(75, 23);
            this.LoginMetroButton.TabIndex = 4;
            this.LoginMetroButton.Text = "Login";
            // 
            // RememberMetroCheckBox
            // 
            this.RememberMetroCheckBox.AutoSize = true;
            this.RememberMetroCheckBox.Location = new System.Drawing.Point(134, 143);
            this.RememberMetroCheckBox.Name = "RememberMetroCheckBox";
            this.RememberMetroCheckBox.Size = new System.Drawing.Size(101, 15);
            this.RememberMetroCheckBox.TabIndex = 5;
            this.RememberMetroCheckBox.Text = "Remember Me";
            this.RememberMetroCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewToOctopusMetroLabel
            // 
            this.NewToOctopusMetroLabel.AutoSize = true;
            this.NewToOctopusMetroLabel.Location = new System.Drawing.Point(134, 172);
            this.NewToOctopusMetroLabel.Name = "NewToOctopusMetroLabel";
            this.NewToOctopusMetroLabel.Size = new System.Drawing.Size(110, 19);
            this.NewToOctopusMetroLabel.TabIndex = 6;
            this.NewToOctopusMetroLabel.Text = "New to Octopus?";
            // 
            // CreateAccountMetroLabel
            // 
            this.CreateAccountMetroLabel.AutoSize = true;
            this.CreateAccountMetroLabel.CustomForeColor = true;
            this.CreateAccountMetroLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateAccountMetroLabel.Location = new System.Drawing.Point(246, 172);
            this.CreateAccountMetroLabel.Name = "CreateAccountMetroLabel";
            this.CreateAccountMetroLabel.Size = new System.Drawing.Size(115, 19);
            this.CreateAccountMetroLabel.TabIndex = 7;
            this.CreateAccountMetroLabel.Text = "Create an account";
            this.CreateAccountMetroLabel.Click += new System.EventHandler(this.CreateAccountMetroLabel_Click);
            this.CreateAccountMetroLabel.MouseLeave += new System.EventHandler(this.CreateAccountMetroLabel_MouseLeave);
            this.CreateAccountMetroLabel.MouseHover += new System.EventHandler(this.CreateAccountMetroLabel_MouseHover);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 211);
            this.Controls.Add(this.CreateAccountMetroLabel);
            this.Controls.Add(this.NewToOctopusMetroLabel);
            this.Controls.Add(this.RememberMetroCheckBox);
            this.Controls.Add(this.LoginMetroButton);
            this.Controls.Add(this.PasswordMetroTextBox);
            this.Controls.Add(this.PasswordMetroLabel);
            this.Controls.Add(this.UsernameMetroLabel);
            this.Controls.Add(this.UsernameMetroTextBox);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Login ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox UsernameMetroTextBox;
        private MetroFramework.Controls.MetroLabel UsernameMetroLabel;
        private MetroFramework.Controls.MetroLabel PasswordMetroLabel;
        private MetroFramework.Controls.MetroTextBox PasswordMetroTextBox;
        private MetroFramework.Controls.MetroButton LoginMetroButton;
        private MetroFramework.Controls.MetroCheckBox RememberMetroCheckBox;
        private MetroFramework.Controls.MetroLabel NewToOctopusMetroLabel;
        private MetroFramework.Controls.MetroLabel CreateAccountMetroLabel;
    }
}