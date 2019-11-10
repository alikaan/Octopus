﻿using System;
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

        private void OctopusMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "\n\nContinue Exit?", "Octopus Dictionary | Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
    }
}
