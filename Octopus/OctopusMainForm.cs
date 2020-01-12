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
using BusinessLayer.Model;
using DataAccessLayer.Model;

namespace Octopus
{
    public partial class OctopusMainForm : MetroFramework.Forms.MetroForm
    {        
        public static bool VocabularyAdd = false;
        public static Vocabulary word = new Vocabulary();        

        public OctopusMainForm()
        {
            InitializeComponent();
        }

        private void UserLoginMetroTile_Click(object sender, EventArgs e)
        {            
            System.Threading.Thread.Sleep(100);
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
            using (AddVocabularyForm form = new AddVocabularyForm())
            {
                form.ShowDialog();
            }
            if(VocabularyAdd)
            {
                DynomoDBUtility dbUtiliy = new DynomoDBUtility();

                VocabularyAdd = false;
                word.ID = 0;
                foreach (DataGridViewRow item in VocabularyDataGridView.Rows)
                {
                    int maxID = Convert.ToInt32(item.Cells["IDColumn"].Value.ToString());
                    if(maxID > word.ID)
                    {
                        word.ID = maxID;
                    }
                }
                word.ID++;
                string[] row = new string[] { word.ID.ToString(), word.Word, word.Meaning, word.Link };
                VocabularyDataGridView.Rows.Add(row);
                dbUtiliy.InsertWord(word);
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
            try
            {
                DynomoDBUtility dbUtiliy = new DynomoDBUtility();

                List<Vocabulary> vocabularies = new List<Vocabulary>();
                vocabularies = dbUtiliy.GetVocabularies("Vocabulary");
                foreach (var item in vocabularies)
                {
                    string[] row = new string[] { item.ID.ToString(), item.Word, item.Meaning, item.Link };
                    VocabularyDataGridView.Rows.Add(row);
                }
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "message", "title", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            
        }

        private void VocabularyDataGridView_SelectionChanged(object sender, EventArgs e)
        {            
            int rowindex = VocabularyDataGridView.CurrentCell.RowIndex;
            VocabularyMetroTextBox.Text = null;
            VocabularyMetroTextBox.AppendText("ID : "         + VocabularyDataGridView.Rows[rowindex].Cells["IDColumn"].Value.ToString() + Environment.NewLine);
            VocabularyMetroTextBox.AppendText("Vocabulary : " + VocabularyDataGridView.Rows[rowindex].Cells["WordColumn"].Value.ToString() + Environment.NewLine);
            VocabularyMetroTextBox.AppendText("Meaning : "    + VocabularyDataGridView.Rows[rowindex].Cells["MeaningColumn"].Value.ToString() + Environment.NewLine);
            VocabularyMetroTextBox.AppendText("Link : "       + VocabularyDataGridView.Rows[rowindex].Cells["LinkColumn"].Value.ToString() + Environment.NewLine);            
        }

    }
}
