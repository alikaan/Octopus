using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Model;

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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure about adding the word?\n", "Octopus Dictionary | Add Vocabulary", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if(String.IsNullOrEmpty(WordMetroTextBox.Text) == false &&
                    String.IsNullOrEmpty(MeaningMetroTextBox.Text) == false &&
                    String.IsNullOrEmpty(LinkMetroTextBox.Text) == false )
                {
                    Vocabulary word = new Vocabulary
                    {
                        Word = WordMetroTextBox.Text,
                        Meaning = MeaningMetroTextBox.Text,
                        Link = LinkMetroTextBox.Text,
                    };
                    OctopusMainForm.word = word;
                    OctopusMainForm.VocabularyAdd = true;
                    this.Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "message", "title", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }                              
            }        
        }
        
    }
}
