using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus
{
    public partial class AddVocabularyForm : MetroFramework.Forms.MetroForm
    {
        public AddVocabularyForm()
        {
            InitializeComponent();
        }

        private void AddVocabularyMetroButton_Click(object sender, EventArgs e)
        {            
            if (MetroFramework.MetroMessageBox.Show(this, "\n", "Octopus Dictionary | Add Vocabulary", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                OctopusMainForm.Vocabulary = VocabularyMetroTextBox.Text;
                OctopusMainForm.VocabularyMeaning = MeaningMetroTextBox.Text;
                OctopusMainForm.VocabularyAdd = true;
                this.Close();
            }        
        }
    }
}
