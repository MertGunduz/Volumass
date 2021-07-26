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
    public partial class Ellipsoid_User_Control : UserControl
    {
        double sigNumber = 1.3333;
        double pi = Math.PI;
        double axis1;
        double axis2;
        double axis3;
        double result;
        string unit;

        public Ellipsoid_User_Control()
        {
            InitializeComponent();
        }

        private void Axis_1_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Axis_1_TextBox.Text == "  Enter The Axis-1 Of Ellipsoid (a)")
            {
                Axis_1_TextBox.Clear();
            }
        }

        private void Axis_2_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Axis_2_TextBox.Text == "  Enter The Axis-2 Of Ellipsoid (b)")
            {
                Axis_2_TextBox.Clear();
            }
        }

        private void Axis_3_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Axis_3_TextBox.Text == "  Enter The Axis-3 Of Ellipsoid (c)")
            {
                Axis_3_TextBox.Clear();
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
                axis1 = Convert.ToDouble(Axis_1_TextBox.Text);
                axis2 = Convert.ToDouble(Axis_2_TextBox.Text);
                axis3 = Convert.ToDouble(Axis_3_TextBox.Text);
                result = sigNumber * pi * axis1 * axis2 * axis3;
                unit = Unit_ComboBox.Text;
                Result_TextBox.Text = result + " " + unit;
            }
        }
    }
}
