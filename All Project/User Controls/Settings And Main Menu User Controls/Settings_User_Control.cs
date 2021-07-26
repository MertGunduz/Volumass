using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumass.User_Controls.Object_User_Controls
{
    public partial class Settings_User_Control : UserControl
    {

        public static bool turkishLanguage;
        public static bool englishLanguage;
        public static bool germanLanguage;

        public Settings_User_Control()
        {
            InitializeComponent();
        }

        private void Turkish_Language_Button_Click(object sender, EventArgs e)
        {
            turkishLanguage = true;
            englishLanguage = false;
            germanLanguage = false;
        }

        private void English_Language_Button_Click(object sender, EventArgs e)
        {
            turkishLanguage = false;
            englishLanguage = true;
            germanLanguage = false;
        }

        private void German_Language_Button_Click(object sender, EventArgs e)
        {
            turkishLanguage = false;
            englishLanguage = false;
            germanLanguage = true;
        }
    }
}
