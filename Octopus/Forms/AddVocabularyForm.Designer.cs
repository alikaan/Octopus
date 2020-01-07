namespace Octopus
{
    partial class AddVocabularyForm
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
            this.WordMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddWordMetroButton = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.MeaningMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LinkMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word :";
            // 
            // WordMetroTextBox
            // 
            // 
            // 
            // 
            this.WordMetroTextBox.CustomButton.Image = null;
            this.WordMetroTextBox.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.WordMetroTextBox.CustomButton.Name = "";
            this.WordMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.WordMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WordMetroTextBox.CustomButton.TabIndex = 1;
            this.WordMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WordMetroTextBox.CustomButton.UseSelectable = true;
            this.WordMetroTextBox.CustomButton.Visible = false;
            this.WordMetroTextBox.Lines = new string[0];
            this.WordMetroTextBox.Location = new System.Drawing.Point(140, 100);
            this.WordMetroTextBox.MaxLength = 32767;
            this.WordMetroTextBox.Name = "WordMetroTextBox";
            this.WordMetroTextBox.PasswordChar = '\0';
            this.WordMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WordMetroTextBox.SelectedText = "";
            this.WordMetroTextBox.SelectionLength = 0;
            this.WordMetroTextBox.SelectionStart = 0;
            this.WordMetroTextBox.ShortcutsEnabled = true;
            this.WordMetroTextBox.Size = new System.Drawing.Size(132, 23);
            this.WordMetroTextBox.TabIndex = 0;
            this.WordMetroTextBox.UseSelectable = true;
            this.WordMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WordMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddWordMetroButton
            // 
            this.AddWordMetroButton.Location = new System.Drawing.Point(354, 266);
            this.AddWordMetroButton.Name = "AddWordMetroButton";
            this.AddWordMetroButton.Size = new System.Drawing.Size(75, 23);
            this.AddWordMetroButton.TabIndex = 2;
            this.AddWordMetroButton.Text = "Add";
            this.AddWordMetroButton.UseSelectable = true;
            this.AddWordMetroButton.Click += new System.EventHandler(this.AddVocabularyMetroButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meaning :";
            // 
            // MeaningMetroTextBox
            // 
            // 
            // 
            // 
            this.MeaningMetroTextBox.CustomButton.Image = null;
            this.MeaningMetroTextBox.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.MeaningMetroTextBox.CustomButton.Name = "";
            this.MeaningMetroTextBox.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.MeaningMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MeaningMetroTextBox.CustomButton.TabIndex = 1;
            this.MeaningMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MeaningMetroTextBox.CustomButton.UseSelectable = true;
            this.MeaningMetroTextBox.CustomButton.Visible = false;
            this.MeaningMetroTextBox.Lines = new string[0];
            this.MeaningMetroTextBox.Location = new System.Drawing.Point(140, 134);
            this.MeaningMetroTextBox.MaxLength = 32767;
            this.MeaningMetroTextBox.Multiline = true;
            this.MeaningMetroTextBox.Name = "MeaningMetroTextBox";
            this.MeaningMetroTextBox.PasswordChar = '\0';
            this.MeaningMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MeaningMetroTextBox.SelectedText = "";
            this.MeaningMetroTextBox.SelectionLength = 0;
            this.MeaningMetroTextBox.SelectionStart = 0;
            this.MeaningMetroTextBox.ShortcutsEnabled = true;
            this.MeaningMetroTextBox.Size = new System.Drawing.Size(289, 72);
            this.MeaningMetroTextBox.TabIndex = 1;
            this.MeaningMetroTextBox.UseSelectable = true;
            this.MeaningMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MeaningMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LinkMetroTextBox
            // 
            // 
            // 
            // 
            this.LinkMetroTextBox.CustomButton.Image = null;
            this.LinkMetroTextBox.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.LinkMetroTextBox.CustomButton.Name = "";
            this.LinkMetroTextBox.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.LinkMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LinkMetroTextBox.CustomButton.TabIndex = 1;
            this.LinkMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LinkMetroTextBox.CustomButton.UseSelectable = true;
            this.LinkMetroTextBox.CustomButton.Visible = false;
            this.LinkMetroTextBox.Lines = new string[0];
            this.LinkMetroTextBox.Location = new System.Drawing.Point(140, 217);
            this.LinkMetroTextBox.MaxLength = 32767;
            this.LinkMetroTextBox.Multiline = true;
            this.LinkMetroTextBox.Name = "LinkMetroTextBox";
            this.LinkMetroTextBox.PasswordChar = '\0';
            this.LinkMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LinkMetroTextBox.SelectedText = "";
            this.LinkMetroTextBox.SelectionLength = 0;
            this.LinkMetroTextBox.SelectionStart = 0;
            this.LinkMetroTextBox.ShortcutsEnabled = true;
            this.LinkMetroTextBox.Size = new System.Drawing.Size(289, 43);
            this.LinkMetroTextBox.TabIndex = 5;
            this.LinkMetroTextBox.UseSelectable = true;
            this.LinkMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LinkMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Link :";
            // 
            // AddVocabularyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 305);
            this.Controls.Add(this.LinkMetroTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MeaningMetroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddWordMetroButton);
            this.Controls.Add(this.WordMetroTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddVocabularyForm";
            this.Resizable = false;
            this.Text = "Add Vocabulary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox WordMetroTextBox;
        private MetroFramework.Controls.MetroButton AddWordMetroButton;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox MeaningMetroTextBox;
        private MetroFramework.Controls.MetroTextBox LinkMetroTextBox;
        private System.Windows.Forms.Label label3;
    }
}