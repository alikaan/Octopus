namespace Octopus
{
    partial class OctopusMainForm
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
            this.UserLoginMetroTile = new MetroFramework.Controls.MetroTile();
            this.SettingsMetroTile = new MetroFramework.Controls.MetroTile();
            this.AddVocabularyMetroTile = new MetroFramework.Controls.MetroTile();
            this.VocabularyDataGridView = new System.Windows.Forms.DataGridView();
            this.ExitMetroTile = new MetroFramework.Controls.MetroTile();
            this.QuizMetroTile = new MetroFramework.Controls.MetroTile();
            this.VocabularyListMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.VocabularyMeaningMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MetroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.CopyrightMetroLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.VocabularyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLoginMetroTile
            // 
            this.UserLoginMetroTile.ActiveControl = null;
            this.UserLoginMetroTile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserLoginMetroTile.Location = new System.Drawing.Point(657, 118);
            this.UserLoginMetroTile.Name = "UserLoginMetroTile";
            this.UserLoginMetroTile.Size = new System.Drawing.Size(120, 66);
            this.UserLoginMetroTile.TabIndex = 0;
            this.UserLoginMetroTile.Text = "Login";
            this.UserLoginMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UserLoginMetroTile.UseSelectable = true;
            this.UserLoginMetroTile.Click += new System.EventHandler(this.UserLoginMetroTile_Click);
            // 
            // SettingsMetroTile
            // 
            this.SettingsMetroTile.ActiveControl = null;
            this.SettingsMetroTile.Location = new System.Drawing.Point(657, 209);
            this.SettingsMetroTile.Name = "SettingsMetroTile";
            this.SettingsMetroTile.Size = new System.Drawing.Size(120, 66);
            this.SettingsMetroTile.TabIndex = 1;
            this.SettingsMetroTile.Text = "Settings";
            this.SettingsMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SettingsMetroTile.UseSelectable = true;
            this.SettingsMetroTile.Click += new System.EventHandler(this.SettingsMetroTile_Click);
            // 
            // AddVocabularyMetroTile
            // 
            this.AddVocabularyMetroTile.ActiveControl = null;
            this.AddVocabularyMetroTile.Location = new System.Drawing.Point(33, 391);
            this.AddVocabularyMetroTile.Name = "AddVocabularyMetroTile";
            this.AddVocabularyMetroTile.Size = new System.Drawing.Size(147, 66);
            this.AddVocabularyMetroTile.TabIndex = 2;
            this.AddVocabularyMetroTile.Text = "Add Vocabulary";
            this.AddVocabularyMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AddVocabularyMetroTile.UseSelectable = true;
            this.AddVocabularyMetroTile.Click += new System.EventHandler(this.AddVocabularyMetroTile_Click);
            // 
            // VocabularyDataGridView
            // 
            this.VocabularyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VocabularyDataGridView.Location = new System.Drawing.Point(33, 118);
            this.VocabularyDataGridView.Name = "VocabularyDataGridView";
            this.VocabularyDataGridView.Size = new System.Drawing.Size(147, 248);
            this.VocabularyDataGridView.TabIndex = 3;
            // 
            // ExitMetroTile
            // 
            this.ExitMetroTile.ActiveControl = null;
            this.ExitMetroTile.Location = new System.Drawing.Point(657, 391);
            this.ExitMetroTile.Name = "ExitMetroTile";
            this.ExitMetroTile.Size = new System.Drawing.Size(120, 66);
            this.ExitMetroTile.TabIndex = 4;
            this.ExitMetroTile.Text = "Exit";
            this.ExitMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ExitMetroTile.UseSelectable = true;
            this.ExitMetroTile.Click += new System.EventHandler(this.ExitMetroTile_Click);
            // 
            // QuizMetroTile
            // 
            this.QuizMetroTile.ActiveControl = null;
            this.QuizMetroTile.Location = new System.Drawing.Point(657, 300);
            this.QuizMetroTile.Name = "QuizMetroTile";
            this.QuizMetroTile.Size = new System.Drawing.Size(120, 66);
            this.QuizMetroTile.TabIndex = 5;
            this.QuizMetroTile.Text = "Quiz";
            this.QuizMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.QuizMetroTile.UseSelectable = true;
            this.QuizMetroTile.Click += new System.EventHandler(this.QuizMetroTile_Click);
            // 
            // VocabularyListMetroLabel
            // 
            this.VocabularyListMetroLabel.AutoSize = true;
            this.VocabularyListMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.VocabularyListMetroLabel.Location = new System.Drawing.Point(33, 84);
            this.VocabularyListMetroLabel.Name = "VocabularyListMetroLabel";
            this.VocabularyListMetroLabel.Size = new System.Drawing.Size(125, 25);
            this.VocabularyListMetroLabel.TabIndex = 6;
            this.VocabularyListMetroLabel.Text = "Vocabulary List";
            // 
            // VocabularyMeaningMetroTextBox
            // 
            // 
            // 
            // 
            this.VocabularyMeaningMetroTextBox.CustomButton.Image = null;
            this.VocabularyMeaningMetroTextBox.CustomButton.Location = new System.Drawing.Point(191, 2);
            this.VocabularyMeaningMetroTextBox.CustomButton.Name = "";
            this.VocabularyMeaningMetroTextBox.CustomButton.Size = new System.Drawing.Size(243, 243);
            this.VocabularyMeaningMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VocabularyMeaningMetroTextBox.CustomButton.TabIndex = 1;
            this.VocabularyMeaningMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VocabularyMeaningMetroTextBox.CustomButton.UseSelectable = true;
            this.VocabularyMeaningMetroTextBox.CustomButton.Visible = false;
            this.VocabularyMeaningMetroTextBox.Lines = new string[0];
            this.VocabularyMeaningMetroTextBox.Location = new System.Drawing.Point(198, 118);
            this.VocabularyMeaningMetroTextBox.MaxLength = 32767;
            this.VocabularyMeaningMetroTextBox.Multiline = true;
            this.VocabularyMeaningMetroTextBox.Name = "VocabularyMeaningMetroTextBox";
            this.VocabularyMeaningMetroTextBox.PasswordChar = '\0';
            this.VocabularyMeaningMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VocabularyMeaningMetroTextBox.SelectedText = "";
            this.VocabularyMeaningMetroTextBox.SelectionLength = 0;
            this.VocabularyMeaningMetroTextBox.SelectionStart = 0;
            this.VocabularyMeaningMetroTextBox.ShortcutsEnabled = true;
            this.VocabularyMeaningMetroTextBox.Size = new System.Drawing.Size(437, 248);
            this.VocabularyMeaningMetroTextBox.TabIndex = 8;
            this.VocabularyMeaningMetroTextBox.UseSelectable = true;
            this.VocabularyMeaningMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VocabularyMeaningMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetroStyleManager
            // 
            this.MetroStyleManager.Owner = null;
            // 
            // CopyrightMetroLabel
            // 
            this.CopyrightMetroLabel.AutoSize = true;
            this.CopyrightMetroLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CopyrightMetroLabel.Location = new System.Drawing.Point(280, 476);
            this.CopyrightMetroLabel.Name = "CopyrightMetroLabel";
            this.CopyrightMetroLabel.Size = new System.Drawing.Size(272, 19);
            this.CopyrightMetroLabel.TabIndex = 9;
            this.CopyrightMetroLabel.Text = "Copyright Octopus 2019. All Rights Reserved.";
            // 
            // OctopusMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.CopyrightMetroLabel);
            this.Controls.Add(this.VocabularyMeaningMetroTextBox);
            this.Controls.Add(this.VocabularyListMetroLabel);
            this.Controls.Add(this.QuizMetroTile);
            this.Controls.Add(this.ExitMetroTile);
            this.Controls.Add(this.VocabularyDataGridView);
            this.Controls.Add(this.AddVocabularyMetroTile);
            this.Controls.Add(this.SettingsMetroTile);
            this.Controls.Add(this.UserLoginMetroTile);
            this.MaximizeBox = false;
            this.Name = "OctopusMainForm";
            this.Resizable = false;
            this.Text = "Octopus Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OctopusMainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.VocabularyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile UserLoginMetroTile;
        private MetroFramework.Controls.MetroTile SettingsMetroTile;
        private MetroFramework.Controls.MetroTile AddVocabularyMetroTile;
        private System.Windows.Forms.DataGridView VocabularyDataGridView;
        private MetroFramework.Controls.MetroTile ExitMetroTile;
        private MetroFramework.Controls.MetroTile QuizMetroTile;
        private MetroFramework.Controls.MetroLabel VocabularyListMetroLabel;
        private MetroFramework.Controls.MetroTextBox VocabularyMeaningMetroTextBox;
        private MetroFramework.Components.MetroStyleManager MetroStyleManager;
        private MetroFramework.Controls.MetroLabel CopyrightMetroLabel;
    }
}

