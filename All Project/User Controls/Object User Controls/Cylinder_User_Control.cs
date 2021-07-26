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
    public partial class Cylinder_User_Control : UserControl
    {
        double pi = Math.PI;
        double baseRadius;
        double height;
        double result;
        string unit;

        public Cylinder_User_Control()
        {
            InitializeComponent();
        }

        private void Base_Radius_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Base_Radius_TextBox.Text == "  Enter The Base Radius Of Cylinder (r)")
            {
                Base_Radius_TextBox.Clear();
            }
        }

        private void Height_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Height_TextBox.Text == "  Enter The Height Of Cylinder (h)")
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
                baseRadius = Convert.ToDouble(Base_Radius_TextBox.Text);
                height = Convert.ToDouble(Height_TextBox.Text);
                unit = Unit_ComboBox.Text;
                result = pi * Math.Pow(baseRadius, 2) * height;
                Result_TextBox.Text = result.ToString() + " " + unit;
            }
        }
    }
}
