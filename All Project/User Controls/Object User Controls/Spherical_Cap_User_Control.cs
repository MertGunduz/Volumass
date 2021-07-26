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
    public partial class Spherical_Cap_User_Control : UserControl
    {
        double sigNumber = 0.3333;
        double pi = Math.PI;
        double height;
        double ballRadius;
        double baseRadius;
        double result;
        string unit;

        public Spherical_Cap_User_Control()
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
                height = Convert.ToDouble(Height_TextBox.Text);
                ballRadius = Convert.ToDouble(Ball_Radius_TextBox.Text);
                baseRadius = Convert.ToDouble(Base_Radius_TextBox.Text);
                result = sigNumber * pi * Math.Pow(height, 2) * ((ballRadius * 3) - height);
                unit = Unit_ComboBox.Text;
                Result_TextBox.Text = result.ToString() + " " + unit;
            }
        }

        private void Base_Radius_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Base_Radius_TextBox.Text == "  Enter The Base Radius Of Spherical Cap (r)")
            {
                Base_Radius_TextBox.Clear();
            }
        }

        private void Ball_Radius_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Ball_Radius_TextBox.Text == "  Enter The Ball Radius Of Spherical Cap (R)")
            {
                Ball_Radius_TextBox.Clear();
            }
        }

        private void Height_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Height_TextBox.Text == "  Enter The Height Of Spherical Cap (h)")
            {
                Height_TextBox.Clear();
            }
        }
    }
}
