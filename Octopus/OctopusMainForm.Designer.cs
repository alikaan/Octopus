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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OctopusMainForm));
            this.UserLoginMetroTile = new MetroFramework.Controls.MetroTile();
            this.SettingsMetroTile = new MetroFramework.Controls.MetroTile();
            this.AddVocabularyMetroTile = new MetroFramework.Controls.MetroTile();
            this.VocabularyDataGridView = new System.Windows.Forms.DataGridView();
            this.VocabularyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VocabularyMeaningColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitMetroTile = new MetroFramework.Controls.MetroTile();
            this.QuizMetroTile = new MetroFramework.Controls.MetroTile();
            this.VocabularyListMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.VocabularyMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CopyrightMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.SearchMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VocabularyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLoginMetroTile
            // 
            this.UserLoginMetroTile.ActiveControl = null;
            resources.ApplyResources(this.UserLoginMetroTile, "UserLoginMetroTile");
            this.UserLoginMetroTile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UserLoginMetroTile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserLoginMetroTile.Name = "UserLoginMetroTile";
            this.UserLoginMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UserLoginMetroTile.UseSelectable = true;
            this.UserLoginMetroTile.Click += new System.EventHandler(this.UserLoginMetroTile_Click);
            // 
            // SettingsMetroTile
            // 
            this.SettingsMetroTile.ActiveControl = null;
            resources.ApplyResources(this.SettingsMetroTile, "SettingsMetroTile");
            this.SettingsMetroTile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SettingsMetroTile.Name = "SettingsMetroTile";
            this.SettingsMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SettingsMetroTile.UseSelectable = true;
            this.SettingsMetroTile.Click += new System.EventHandler(this.SettingsMetroTile_Click);
            // 
            // AddVocabularyMetroTile
            // 
            this.AddVocabularyMetroTile.ActiveControl = null;
            this.AddVocabularyMetroTile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.AddVocabularyMetroTile, "AddVocabularyMetroTile");
            this.AddVocabularyMetroTile.Name = "AddVocabularyMetroTile";
            this.AddVocabularyMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AddVocabularyMetroTile.UseSelectable = true;
            this.AddVocabularyMetroTile.Click += new System.EventHandler(this.AddVocabularyMetroTile_Click);
            // 
            // VocabularyDataGridView
            // 
            this.VocabularyDataGridView.AllowUserToAddRows = false;
            this.VocabularyDataGridView.AllowUserToDeleteRows = false;
            this.VocabularyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VocabularyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VocabularyColumn,
            this.VocabularyMeaningColumn});
            resources.ApplyResources(this.VocabularyDataGridView, "VocabularyDataGridView");
            this.VocabularyDataGridView.Name = "VocabularyDataGridView";
            this.VocabularyDataGridView.ReadOnly = true;
            this.VocabularyDataGridView.SelectionChanged += new System.EventHandler(this.VocabularyDataGridView_SelectionChanged);
            // 
            // VocabularyColumn
            // 
            resources.ApplyResources(this.VocabularyColumn, "VocabularyColumn");
            this.VocabularyColumn.Name = "VocabularyColumn";
            this.VocabularyColumn.ReadOnly = true;
            // 
            // VocabularyMeaningColumn
            // 
            resources.ApplyResources(this.VocabularyMeaningColumn, "VocabularyMeaningColumn");
            this.VocabularyMeaningColumn.Name = "VocabularyMeaningColumn";
            this.VocabularyMeaningColumn.ReadOnly = true;
            // 
            // ExitMetroTile
            // 
            this.ExitMetroTile.ActiveControl = null;
            resources.ApplyResources(this.ExitMetroTile, "ExitMetroTile");
            this.ExitMetroTile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitMetroTile.Name = "ExitMetroTile";
            this.ExitMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ExitMetroTile.UseSelectable = true;
            this.ExitMetroTile.Click += new System.EventHandler(this.ExitMetroTile_Click);
            // 
            // QuizMetroTile
            // 
            this.QuizMetroTile.ActiveControl = null;
            resources.ApplyResources(this.QuizMetroTile, "QuizMetroTile");
            this.QuizMetroTile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuizMetroTile.Name = "QuizMetroTile";
            this.QuizMetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.QuizMetroTile.UseSelectable = true;
            this.QuizMetroTile.Click += new System.EventHandler(this.QuizMetroTile_Click);
            // 
            // VocabularyListMetroLabel
            // 
            resources.ApplyResources(this.VocabularyListMetroLabel, "VocabularyListMetroLabel");
            this.VocabularyListMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.VocabularyListMetroLabel.Name = "VocabularyListMetroLabel";
            // 
            // VocabularyMetroTextBox
            // 
            // 
            // 
            // 
            this.VocabularyMetroTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.VocabularyMetroTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.VocabularyMetroTextBox.CustomButton.Name = "";
            this.VocabularyMetroTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.VocabularyMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VocabularyMetroTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.VocabularyMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VocabularyMetroTextBox.CustomButton.UseSelectable = true;
            this.VocabularyMetroTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.VocabularyMetroTextBox.Lines = new string[0];
            resources.ApplyResources(this.VocabularyMetroTextBox, "VocabularyMetroTextBox");
            this.VocabularyMetroTextBox.MaxLength = 32767;
            this.VocabularyMetroTextBox.Multiline = true;
            this.VocabularyMetroTextBox.Name = "VocabularyMetroTextBox";
            this.VocabularyMetroTextBox.PasswordChar = '\0';
            this.VocabularyMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VocabularyMetroTextBox.SelectedText = "";
            this.VocabularyMetroTextBox.SelectionLength = 0;
            this.VocabularyMetroTextBox.SelectionStart = 0;
            this.VocabularyMetroTextBox.ShortcutsEnabled = true;
            this.VocabularyMetroTextBox.UseSelectable = true;
            this.VocabularyMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VocabularyMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CopyrightMetroLabel
            // 
            resources.ApplyResources(this.CopyrightMetroLabel, "CopyrightMetroLabel");
            this.CopyrightMetroLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CopyrightMetroLabel.Name = "CopyrightMetroLabel";
            // 
            // SearchMetroTextBox
            // 
            // 
            // 
            // 
            this.SearchMetroTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.SearchMetroTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.SearchMetroTextBox.CustomButton.Name = "";
            this.SearchMetroTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.SearchMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchMetroTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.SearchMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchMetroTextBox.CustomButton.UseSelectable = true;
            this.SearchMetroTextBox.DisplayIcon = true;
            this.SearchMetroTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("SearchMetroTextBox.Icon")));
            this.SearchMetroTextBox.Lines = new string[0];
            resources.ApplyResources(this.SearchMetroTextBox, "SearchMetroTextBox");
            this.SearchMetroTextBox.MaxLength = 32767;
            this.SearchMetroTextBox.Name = "SearchMetroTextBox";
            this.SearchMetroTextBox.PasswordChar = '\0';
            this.SearchMetroTextBox.PromptText = "Search";
            this.SearchMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchMetroTextBox.SelectedText = "";
            this.SearchMetroTextBox.SelectionLength = 0;
            this.SearchMetroTextBox.SelectionStart = 0;
            this.SearchMetroTextBox.ShortcutsEnabled = true;
            this.SearchMetroTextBox.ShowButton = true;
            this.SearchMetroTextBox.ShowClearButton = true;
            this.SearchMetroTextBox.UseSelectable = true;
            this.SearchMetroTextBox.WaterMark = "Search";
            this.SearchMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchMetroTextBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.SearchMetroTextBox_ButtonClick);            
            // 
            // OctopusMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Octopus.Properties.Resources.octopus_40px;
            this.BackImagePadding = new System.Windows.Forms.Padding(530, 15, 0, 0);
            this.BackMaxSize = 40;
            this.Controls.Add(this.UserLoginMetroTile);
            this.Controls.Add(this.SettingsMetroTile);
            this.Controls.Add(this.VocabularyMetroTextBox);
            this.Controls.Add(this.SearchMetroTextBox);
            this.Controls.Add(this.QuizMetroTile);
            this.Controls.Add(this.CopyrightMetroLabel);
            this.Controls.Add(this.ExitMetroTile);
            this.Controls.Add(this.VocabularyListMetroLabel);
            this.Controls.Add(this.VocabularyDataGridView);
            this.Controls.Add(this.AddVocabularyMetroTile);
            this.MaximizeBox = false;
            this.Name = "OctopusMainForm";
            this.Resizable = false;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OctopusMainForm_FormClosing);
            this.Load += new System.EventHandler(this.OctopusMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VocabularyDataGridView)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox VocabularyMetroTextBox;
        private MetroFramework.Controls.MetroLabel CopyrightMetroLabel;
        private MetroFramework.Controls.MetroTextBox SearchMetroTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn VocabularyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VocabularyMeaningColumn;
    }
}

