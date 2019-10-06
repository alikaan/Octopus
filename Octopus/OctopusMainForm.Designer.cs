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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExitMetroTile = new MetroFramework.Controls.MetroTile();
            this.QuizMetroTile = new MetroFramework.Controls.MetroTile();
            this.VocabularyListMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.ThemeMetroToggle = new MetroFramework.Controls.MetroToggle();
            this.VocabularyMeaningMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MetroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLoginMetroTile
            // 
            this.UserLoginMetroTile.Location = new System.Drawing.Point(657, 118);
            this.UserLoginMetroTile.Name = "UserLoginMetroTile";
            this.UserLoginMetroTile.Size = new System.Drawing.Size(120, 66);
            this.UserLoginMetroTile.TabIndex = 0;
            this.UserLoginMetroTile.Text = "Login";
            this.UserLoginMetroTile.Click += new System.EventHandler(this.UserLoginMetroTile_Click);
            // 
            // SettingsMetroTile
            // 
            this.SettingsMetroTile.Location = new System.Drawing.Point(657, 209);
            this.SettingsMetroTile.Name = "SettingsMetroTile";
            this.SettingsMetroTile.Size = new System.Drawing.Size(120, 66);
            this.SettingsMetroTile.TabIndex = 1;
            this.SettingsMetroTile.Text = "Settings";
            this.SettingsMetroTile.Click += new System.EventHandler(this.SettingsMetroTile_Click);
            // 
            // AddVocabularyMetroTile
            // 
            this.AddVocabularyMetroTile.Location = new System.Drawing.Point(33, 391);
            this.AddVocabularyMetroTile.Name = "AddVocabularyMetroTile";
            this.AddVocabularyMetroTile.Size = new System.Drawing.Size(120, 66);
            this.AddVocabularyMetroTile.TabIndex = 2;
            this.AddVocabularyMetroTile.Text = "Add Vocabulary";
            this.AddVocabularyMetroTile.Click += new System.EventHandler(this.AddVocabularyMetroTile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(120, 248);
            this.dataGridView1.TabIndex = 3;
            // 
            // ExitMetroTile
            // 
            this.ExitMetroTile.Location = new System.Drawing.Point(657, 391);
            this.ExitMetroTile.Name = "ExitMetroTile";
            this.ExitMetroTile.Size = new System.Drawing.Size(120, 66);
            this.ExitMetroTile.TabIndex = 4;
            this.ExitMetroTile.Text = "Exit";
            this.ExitMetroTile.Click += new System.EventHandler(this.ExitMetroTile_Click);
            // 
            // QuizMetroTile
            // 
            this.QuizMetroTile.Location = new System.Drawing.Point(657, 300);
            this.QuizMetroTile.Name = "QuizMetroTile";
            this.QuizMetroTile.Size = new System.Drawing.Size(120, 66);
            this.QuizMetroTile.TabIndex = 5;
            this.QuizMetroTile.Text = "Quiz";
            this.QuizMetroTile.Click += new System.EventHandler(this.QuizMetroTile_Click);
            // 
            // VocabularyListMetroLabel
            // 
            this.VocabularyListMetroLabel.AutoSize = true;
            this.VocabularyListMetroLabel.Location = new System.Drawing.Point(33, 84);
            this.VocabularyListMetroLabel.Name = "VocabularyListMetroLabel";
            this.VocabularyListMetroLabel.Size = new System.Drawing.Size(96, 19);
            this.VocabularyListMetroLabel.TabIndex = 6;
            this.VocabularyListMetroLabel.Text = "Vocabulary List";
            // 
            // ThemeMetroToggle
            // 
            this.ThemeMetroToggle.AutoSize = true;
            this.ThemeMetroToggle.Location = new System.Drawing.Point(697, 84);
            this.ThemeMetroToggle.Name = "ThemeMetroToggle";
            this.ThemeMetroToggle.Size = new System.Drawing.Size(80, 17);
            this.ThemeMetroToggle.TabIndex = 7;
            this.ThemeMetroToggle.Text = "Off";
            this.ThemeMetroToggle.UseVisualStyleBackColor = true;
            this.ThemeMetroToggle.CheckedChanged += new System.EventHandler(this.ThemeMetroToggle_CheckedChanged);
            // 
            // VocabularyMeaningMetroTextBox
            // 
            this.VocabularyMeaningMetroTextBox.Location = new System.Drawing.Point(159, 118);
            this.VocabularyMeaningMetroTextBox.Multiline = true;
            this.VocabularyMeaningMetroTextBox.Name = "VocabularyMeaningMetroTextBox";
            this.VocabularyMeaningMetroTextBox.Size = new System.Drawing.Size(466, 248);
            this.VocabularyMeaningMetroTextBox.TabIndex = 8;
            // 
            // MetroStyleManager
            // 
            this.MetroStyleManager.Owner = null;
            // 
            // OctopusMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.VocabularyMeaningMetroTextBox);
            this.Controls.Add(this.ThemeMetroToggle);
            this.Controls.Add(this.VocabularyListMetroLabel);
            this.Controls.Add(this.QuizMetroTile);
            this.Controls.Add(this.ExitMetroTile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddVocabularyMetroTile);
            this.Controls.Add(this.SettingsMetroTile);
            this.Controls.Add(this.UserLoginMetroTile);
            this.Name = "OctopusMainForm";
            this.Resizable = false;
            this.Text = "Octopus Dictionary";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile UserLoginMetroTile;
        private MetroFramework.Controls.MetroTile SettingsMetroTile;
        private MetroFramework.Controls.MetroTile AddVocabularyMetroTile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTile ExitMetroTile;
        private MetroFramework.Controls.MetroTile QuizMetroTile;
        private MetroFramework.Controls.MetroLabel VocabularyListMetroLabel;
        private MetroFramework.Controls.MetroToggle ThemeMetroToggle;
        private MetroFramework.Controls.MetroTextBox VocabularyMeaningMetroTextBox;
        private MetroFramework.Components.MetroStyleManager MetroStyleManager;
    }
}

