using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LanguageIdentifier
{
    internal partial class SettingsForm_LanguageIdentifier : Form
    {


        #region Get and Set Options

        public string LanguageModel;

       #endregion



        public SettingsForm_LanguageIdentifier(string LangMod)
        {
            InitializeComponent();

            

            switch(LangMod)
            {
                case "Core14.profile.xml":
                    Core14LangSelection.Checked = true;
                    break;
                case "Wiki82.profile.xml":
                    Wiki82Selection.Checked = true;
                    break;
                case "Wiki280.profile.xml":
                    Wiki280Selection.Checked = true;
                    break;

            }
            
            
            



        }






        private void OKButton_Click(object sender, System.EventArgs e)
        {

            
            if (Core14LangSelection.Checked) LanguageModel = "Core14.profile.xml";
            else if (Wiki82Selection.Checked) LanguageModel = "Wiki82.profile.xml";
            else if (Wiki280Selection.Checked) LanguageModel = "Wiki280.profile.xml";

            this.DialogResult = DialogResult.OK;

        }
    }
}
