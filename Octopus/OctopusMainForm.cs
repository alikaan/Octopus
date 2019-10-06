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
        public OctopusMainForm()
        {
            InitializeComponent();
        }

        private void UserLoginMetroTile_Click(object sender, EventArgs e)
        {
            using (LoginForm form = new LoginForm())
            {
                form.ShowDialog();
            }
        }

        private void ExitMetroTile_Click(object sender, EventArgs e)
        {                      
            if(MessageBox.Show(this, "\n\nContinue Exit?", "Octopus Dictionary | Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            using (QuizForm form = new QuizForm())
            {
                form.ShowDialog();
            }
        }

        private void ThemeMetroToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(ThemeMetroToggle.Checked)
            {
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                VocabularyListMetroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                UserLoginMetroTile.Theme = MetroFramework.MetroThemeStyle.Dark;
                SettingsMetroTile.Theme = MetroFramework.MetroThemeStyle.Dark;
                QuizMetroTile.Theme = MetroFramework.MetroThemeStyle.Dark;
                ExitMetroTile.Theme = MetroFramework.MetroThemeStyle.Dark;
                AddVocabularyMetroTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                this.Theme = MetroFramework.MetroThemeStyle.Light;
                VocabularyListMetroLabel.Theme = MetroFramework.MetroThemeStyle.Light;
                UserLoginMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
                SettingsMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
                QuizMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
                ExitMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
                AddVocabularyMetroTile.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            
        }

    }
}
