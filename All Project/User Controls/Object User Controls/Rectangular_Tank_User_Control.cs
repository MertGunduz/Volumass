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
    public partial class Rectangular_Tank_User_Control : UserControl
    {

        double length;
        double width;
        double height;
        double result;
        string lengthUnit;

        public Rectangular_Tank_User_Control()
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
                lengthUnit = Unit_ComboBox.Text;
                length = Convert.ToDouble(Length_TextBox.Text);
                width = Convert.ToDouble(Width_TextBox.Text);
                height = Convert.ToDouble(Height_TextBox.Text);
                result = length * width * height;
                Result_TextBox.Text = result.ToString() + " " + lengthUnit;
            }
        }

        private void Length_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Length_TextBox.Text == "  Enter The Length Of Rectangular Tank (l)")
            {
                Length_TextBox.Clear();
            }
        }

        private void Width_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Width_TextBox.Text == "  Enter The Width Of Rectangular Tank (w)")
            {
                Width_TextBox.Clear();
            }
        }

        private void Height_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Height_TextBox.Text == "  Enter The Height Of Rectangular Tank (h)")
            {
                Height_TextBox.Clear();
            }
        }
    }
}
