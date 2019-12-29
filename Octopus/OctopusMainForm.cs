using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Octopus
{
    public partial class OctopusMainForm : MetroFramework.Forms.MetroForm
    {        
        public static bool VocabularyAdd = false;
        public static string Vocabulary;
        public static string VocabularyMeaning;

        public OctopusMainForm()
        {
            InitializeComponent();
        }

        private void UserLoginMetroTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(500);
            using (LoginForm form = new LoginForm())
            {
                form.ShowDialog();                
            }
            this.Show();
            this.Focus();
        }

        private void ExitMetroTile_Click(object sender, EventArgs e)
        {                                  
            if(MetroFramework.MetroMessageBox.Show(this, "\n\nContinue Exit?", "Octopus Dictionary | Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }

        private void AddVocabularyMetroTile_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "thanks for click");
            using (AddVocabularyForm form = new AddVocabularyForm())
            {
                form.ShowDialog();
            }
            if(VocabularyAdd)
            {
                string[] row = new string[] { Vocabulary, VocabularyMeaning };
                VocabularyDataGridView.Rows.Add(row);
                // add new vocabulary here
            }
        }

        private void SettingsMetroTile_Click(object sender, EventArgs e)
        {
            using (SettingsForm form = new SettingsForm())
            {
                form.ShowDialog();
            }
        }

        private void QuizMetroTile_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.Show();
            
        }

        private void OctopusMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Continue Exit?", "Octopus Dictionary | Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Application.Exit();
                }   
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void SearchMetroTextBox_ButtonClick(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "thanks for click");
        }

        private void OctopusMainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void VocabularyDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = VocabularyDataGridView.CurrentCell.RowIndex;
            VocabularyMetroTextBox.Text = null;
            VocabularyMetroTextBox.AppendText("Vocabulary : " + VocabularyDataGridView.Rows[rowindex].Cells["VocabularyColumn"].Value.ToString() + Environment.NewLine);
            VocabularyMetroTextBox.AppendText("Meaning : " + VocabularyDataGridView.Rows[rowindex].Cells["VocabularyMeaningColumn"].Value.ToString() + Environment.NewLine);
        }
    }
}
