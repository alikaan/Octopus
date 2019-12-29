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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernameMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.LoginMetroButton = new MetroFramework.Controls.MetroButton();
            this.RememberMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.NewToOctopusMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.CreateAccountMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UsernameMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginMetroPanel = new MetroFramework.Controls.MetroPanel();
            this.LoginMetroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameMetroLabel
            // 
            this.UsernameMetroLabel.AutoSize = true;
            this.UsernameMetroLabel.Location = new System.Drawing.Point(6, 12);
            this.UsernameMetroLabel.Name = "UsernameMetroLabel";
            this.UsernameMetroLabel.Size = new System.Drawing.Size(75, 19);
            this.UsernameMetroLabel.TabIndex = 6;
            this.UsernameMetroLabel.Text = "Username :";
            // 
            // PasswordMetroLabel
            // 
            this.PasswordMetroLabel.AutoSize = true;
            this.PasswordMetroLabel.Location = new System.Drawing.Point(6, 45);
            this.PasswordMetroLabel.Name = "PasswordMetroLabel";
            this.PasswordMetroLabel.Size = new System.Drawing.Size(70, 19);
            this.PasswordMetroLabel.TabIndex = 7;
            this.PasswordMetroLabel.Text = "Password :";
            // 
            // LoginMetroButton
            // 
            this.LoginMetroButton.Location = new System.Drawing.Point(259, 45);
            this.LoginMetroButton.Name = "LoginMetroButton";
            this.LoginMetroButton.Size = new System.Drawing.Size(75, 23);
            this.LoginMetroButton.TabIndex = 2;
            this.LoginMetroButton.Text = "Login";
            this.LoginMetroButton.UseSelectable = true;
            // 
            // RememberMetroCheckBox
            // 
            this.RememberMetroCheckBox.AutoSize = true;
            this.RememberMetroCheckBox.Location = new System.Drawing.Point(107, 74);
            this.RememberMetroCheckBox.Name = "RememberMetroCheckBox";
            this.RememberMetroCheckBox.Size = new System.Drawing.Size(101, 15);
            this.RememberMetroCheckBox.TabIndex = 3;
            this.RememberMetroCheckBox.Text = "Remember Me";
            this.RememberMetroCheckBox.UseSelectable = true;
            // 
            // NewToOctopusMetroLabel
            // 
            this.NewToOctopusMetroLabel.AutoSize = true;
            this.NewToOctopusMetroLabel.Location = new System.Drawing.Point(107, 103);
            this.NewToOctopusMetroLabel.Name = "NewToOctopusMetroLabel";
            this.NewToOctopusMetroLabel.Size = new System.Drawing.Size(110, 19);
            this.NewToOctopusMetroLabel.TabIndex = 4;
            this.NewToOctopusMetroLabel.Text = "New to Octopus?";
            // 
            // CreateAccountMetroLabel
            // 
            this.CreateAccountMetroLabel.AutoSize = true;
            this.CreateAccountMetroLabel.ForeColor = System.Drawing.Color.Navy;
            this.CreateAccountMetroLabel.Location = new System.Drawing.Point(219, 103);
            this.CreateAccountMetroLabel.Name = "CreateAccountMetroLabel";
            this.CreateAccountMetroLabel.Size = new System.Drawing.Size(115, 19);
            this.CreateAccountMetroLabel.TabIndex = 5;
            this.CreateAccountMetroLabel.Text = "Create an account";
            this.CreateAccountMetroLabel.Click += new System.EventHandler(this.CreateAccountMetroLabel_Click);
            // 
            // PasswordMetroTextBox
            // 
            // 
            // 
            // 
            this.PasswordMetroTextBox.CustomButton.Image = null;
            this.PasswordMetroTextBox.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.PasswordMetroTextBox.CustomButton.Name = "";
            this.PasswordMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordMetroTextBox.CustomButton.TabIndex = 1;
            this.PasswordMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordMetroTextBox.CustomButton.UseSelectable = true;
            this.PasswordMetroTextBox.CustomButton.Visible = false;
            this.PasswordMetroTextBox.DisplayIcon = true;
            this.PasswordMetroTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("PasswordMetroTextBox.Icon")));
            this.PasswordMetroTextBox.Lines = new string[0];
            this.PasswordMetroTextBox.Location = new System.Drawing.Point(107, 45);
            this.PasswordMetroTextBox.MaxLength = 32767;
            this.PasswordMetroTextBox.Name = "PasswordMetroTextBox";
            this.PasswordMetroTextBox.PasswordChar = '\0';
            this.PasswordMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordMetroTextBox.SelectedText = "";
            this.PasswordMetroTextBox.SelectionLength = 0;
            this.PasswordMetroTextBox.SelectionStart = 0;
            this.PasswordMetroTextBox.ShortcutsEnabled = true;
            this.PasswordMetroTextBox.ShowClearButton = true;
            this.PasswordMetroTextBox.Size = new System.Drawing.Size(121, 23);
            this.PasswordMetroTextBox.TabIndex = 1;
            this.PasswordMetroTextBox.UseSelectable = true;
            this.PasswordMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UsernameMetroTextBox
            // 
            // 
            // 
            // 
            this.UsernameMetroTextBox.CustomButton.Image = null;
            this.UsernameMetroTextBox.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.UsernameMetroTextBox.CustomButton.Name = "";
            this.UsernameMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernameMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameMetroTextBox.CustomButton.TabIndex = 1;
            this.UsernameMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameMetroTextBox.CustomButton.UseSelectable = true;
            this.UsernameMetroTextBox.CustomButton.Visible = false;
            this.UsernameMetroTextBox.DisplayIcon = true;
            this.UsernameMetroTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("UsernameMetroTextBox.Icon")));
            this.UsernameMetroTextBox.Lines = new string[0];
            this.UsernameMetroTextBox.Location = new System.Drawing.Point(107, 12);
            this.UsernameMetroTextBox.MaxLength = 32767;
            this.UsernameMetroTextBox.Name = "UsernameMetroTextBox";
            this.UsernameMetroTextBox.PasswordChar = '\0';
            this.UsernameMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameMetroTextBox.SelectedText = "";
            this.UsernameMetroTextBox.SelectionLength = 0;
            this.UsernameMetroTextBox.SelectionStart = 0;
            this.UsernameMetroTextBox.ShortcutsEnabled = true;
            this.UsernameMetroTextBox.ShowClearButton = true;
            this.UsernameMetroTextBox.Size = new System.Drawing.Size(121, 23);
            this.UsernameMetroTextBox.TabIndex = 0;
            this.UsernameMetroTextBox.UseSelectable = true;
            this.UsernameMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginMetroPanel
            // 
            this.LoginMetroPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LoginMetroPanel.Controls.Add(this.NewToOctopusMetroLabel);
            this.LoginMetroPanel.Controls.Add(this.CreateAccountMetroLabel);
            this.LoginMetroPanel.Controls.Add(this.UsernameMetroLabel);
            this.LoginMetroPanel.Controls.Add(this.RememberMetroCheckBox);
            this.LoginMetroPanel.Controls.Add(this.UsernameMetroTextBox);
            this.LoginMetroPanel.Controls.Add(this.LoginMetroButton);
            this.LoginMetroPanel.Controls.Add(this.PasswordMetroLabel);
            this.LoginMetroPanel.Controls.Add(this.PasswordMetroTextBox);
            this.LoginMetroPanel.HorizontalScrollbarBarColor = true;
            this.LoginMetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LoginMetroPanel.HorizontalScrollbarSize = 10;
            this.LoginMetroPanel.Location = new System.Drawing.Point(23, 63);
            this.LoginMetroPanel.Name = "LoginMetroPanel";
            this.LoginMetroPanel.Size = new System.Drawing.Size(348, 138);
            this.LoginMetroPanel.TabIndex = 0;
            this.LoginMetroPanel.VerticalScrollbarBarColor = true;
            this.LoginMetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LoginMetroPanel.VerticalScrollbarSize = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 221);
            this.Controls.Add(this.LoginMetroPanel);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Login ";
            this.LoginMetroPanel.ResumeLayout(false);
            this.LoginMetroPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private MetroFramework.Controls.MetroPanel LoginMetroPanel;
    }
}