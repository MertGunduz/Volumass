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
    public partial class Cone_User_Control : UserControl
    {
        double sigNumber = 0.3333;
        double pi = Math.PI;
        double baseRadius;
        double height;
        double result;
        string unit;

        public Cone_User_Control()
        {
            InitializeComponent();
        }

        private void Calculate_Volume_Button_Click(object sender, EventArgs e)
        {
            if (Unit_ComboBox.Text == "  Select The Unit Of Length" || Unit_ComboBox.Text == "")
            {
                MessageBox.Show("Please Pick A Length Unit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baseRadius = Convert.ToDouble(BaseRadius_TextBox.Text);
                height = Convert.ToDouble(Height_TextBox.Text);
                result = sigNumber * pi * Math.Pow(baseRadius, 2) * height;
                unit = Unit_ComboBox.Text;
                Result_TextBox.Text = result + " " + unit;
            }
        }

        private void BaseRadius_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (BaseRadius_TextBox.Text == "  Enter The Base Radius Of Cone (r)")
            {
                BaseRadius_TextBox.Clear();
            }
        }

        private void Height_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Height_TextBox.Text == "  Enter The Height Of Cone (h)")
            {
                Height_TextBox.Clear();
            }
        }
    }
}
