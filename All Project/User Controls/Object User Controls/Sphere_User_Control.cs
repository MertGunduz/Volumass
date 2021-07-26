using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumass.User_Controls
{
    public partial class Sphere_User_Control : UserControl
    {

        double radius;
        double sigNumber = 1.3333;
        double pi = Math.PI;
        double result;
        string lengthUnit;

        public Sphere_User_Control()
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
                radius = Convert.ToDouble(Radius_Textbox.Text);
                result = sigNumber * pi * Math.Pow(radius, 3);
                lengthUnit = Unit_ComboBox.Text;
                Result_TextBox.Text = result.ToString() + " " + lengthUnit;
            }
        }

        private void Radius_Textbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Radius_Textbox.Text ==  "  Enter The Radius Of Sphere (r)")
            {
                Radius_Textbox.Clear();
            }
        }
    }
}
