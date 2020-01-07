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
            if (MetroFramework.MetroMessageBox.Show(this, "\n", "Octopus Dictionary | Add Vocabulary", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Vocabulary word = new Vocabulary
                {
                    Word = "helo",
                    Meaning = "hello",
                    Link = "bla",
                    ID = 4                    
                };
                OctopusMainForm.word = word;                
                OctopusMainForm.VocabularyAdd = true;
                this.Close();
            }        
        }
        
    }
}
