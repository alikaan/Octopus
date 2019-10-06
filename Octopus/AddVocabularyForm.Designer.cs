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
            this.VocabularyMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddVocabularyMetroButton = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.MeaningMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vocabulary :";
            // 
            // VocabularyMetroTextBox
            // 
            this.VocabularyMetroTextBox.Location = new System.Drawing.Point(140, 100);
            this.VocabularyMetroTextBox.Name = "VocabularyMetroTextBox";
            this.VocabularyMetroTextBox.Size = new System.Drawing.Size(132, 23);
            this.VocabularyMetroTextBox.TabIndex = 1;
            // 
            // AddVocabularyMetroButton
            // 
            this.AddVocabularyMetroButton.Location = new System.Drawing.Point(354, 266);
            this.AddVocabularyMetroButton.Name = "AddVocabularyMetroButton";
            this.AddVocabularyMetroButton.Size = new System.Drawing.Size(75, 23);
            this.AddVocabularyMetroButton.TabIndex = 2;
            this.AddVocabularyMetroButton.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meaning :";
            // 
            // MeaningMetroTextBox
            // 
            this.MeaningMetroTextBox.Location = new System.Drawing.Point(140, 136);
            this.MeaningMetroTextBox.Multiline = true;
            this.MeaningMetroTextBox.Name = "MeaningMetroTextBox";
            this.MeaningMetroTextBox.Size = new System.Drawing.Size(289, 107);
            this.MeaningMetroTextBox.TabIndex = 4;
            // 
            // AddVocabularyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 305);
            this.Controls.Add(this.MeaningMetroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddVocabularyMetroButton);
            this.Controls.Add(this.VocabularyMetroTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddVocabularyForm";
            this.Resizable = false;
            this.Text = "Add Vocabulary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox VocabularyMetroTextBox;
        private MetroFramework.Controls.MetroButton AddVocabularyMetroButton;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox MeaningMetroTextBox;
    }
}