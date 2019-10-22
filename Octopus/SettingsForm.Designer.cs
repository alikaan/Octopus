namespace Octopus
{
    partial class SettingsForm
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
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.SaveSettingsMetroButton = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(34, 64);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(74, 15);
            this.metroCheckBox1.TabIndex = 0;
            this.metroCheckBox1.Text = "Settings 1";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(34, 85);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(74, 15);
            this.metroCheckBox2.TabIndex = 1;
            this.metroCheckBox2.Text = "Settings 2";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(34, 106);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(74, 15);
            this.metroCheckBox3.TabIndex = 2;
            this.metroCheckBox3.Text = "Settings 3";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // SaveSettingsMetroButton
            // 
            this.SaveSettingsMetroButton.Location = new System.Drawing.Point(34, 163);
            this.SaveSettingsMetroButton.Name = "SaveSettingsMetroButton";
            this.SaveSettingsMetroButton.Size = new System.Drawing.Size(75, 23);
            this.SaveSettingsMetroButton.TabIndex = 3;
            this.SaveSettingsMetroButton.Text = "Save";
            this.SaveSettingsMetroButton.UseSelectable = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(34, 127);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(74, 15);
            this.metroCheckBox4.TabIndex = 4;
            this.metroCheckBox4.Text = "Settings 4";
            this.metroCheckBox4.UseSelectable = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 202);
            this.Controls.Add(this.metroCheckBox4);
            this.Controls.Add(this.SaveSettingsMetroButton);
            this.Controls.Add(this.metroCheckBox3);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Resizable = false;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroButton SaveSettingsMetroButton;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
    }
}