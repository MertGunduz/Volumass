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
    public partial class Conical_Frustum_User_Control : UserControl
    {
        double sigNumber = 0.3333;
        double pi = Math.PI;
        double height;
        double topRadius;
        double bottomRadius;
        double result;
        string unit;

        public Conical_Frustum_User_Control()
        {
            InitializeComponent();
        }

        private void TopRadius_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (TopRadius_TextBox.Text == "  Enter The Top Radius Of Conical Frustum (r)")
            {
                TopRadius_TextBox.Clear();
            }
        }

        private void BottomRadius_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (BottomRadius_TextBox.Text == "  Enter The Bottom Radius Of Conical Frustum (R)")
            {
                BottomRadius_TextBox.Clear();
            }
        }

        private void Height_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Height_TextBox.Text == "  Enter The Height Of Conical Frustum (h)")
            {
                Height_TextBox.Clear();
            }
        }

        private void Calculate_Volume_Button_Click(object sender, EventArgs e)
        {
            if (Unit_ComboBox.Text == "  Select The Unit Of Length" || Unit_ComboBox.Text == "")
            {
                MessageBox.Show("Please Pick A Length Unit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                topRadius = Convert.ToDouble(TopRadius_TextBox.Text);
                bottomRadius = Convert.ToDouble(BottomRadius_TextBox.Text);
                height = Convert.ToDouble(Height_TextBox.Text);
                result = sigNumber * pi * height * (Math.Pow(topRadius, 2) + topRadius * bottomRadius + Math.Pow(bottomRadius, 2));
                unit = Unit_ComboBox.Text;
                Result_TextBox.Text = result + " " + unit;
            }
        }
    }
}
