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
    public partial class Tube_User_Control : UserControl
    {

        double pi = Math.PI;
        double innerDiameter;
        double outerDiameter;
        double length;
        double result;
        string unit;

        public Tube_User_Control()
        {
            InitializeComponent();
        }

        private void Outer_Diameter_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Outer_Diameter_TextBox.Text == "  Enter The Outer Diameter Of Tube (d1)")
            {
                Outer_Diameter_TextBox.Clear();
            }
        }

        private void Inner_Diameter_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Inner_Diameter_TextBox.Text == "  Enter The Inner Diameter Of Tube (d2)")
            {
                Inner_Diameter_TextBox.Clear();
            }
        }

        private void Length_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Length_TextBox.Text == "  Enter The Length Of Tube (l)")
            {
                Length_TextBox.Clear();
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
                innerDiameter = Convert.ToDouble(Inner_Diameter_TextBox.Text);
                outerDiameter = Convert.ToDouble(Outer_Diameter_TextBox.Text);
                length = Convert.ToDouble(Length_TextBox.Text);
                result = pi * (Math.Pow(outerDiameter, 2) - Math.Pow(innerDiameter, 2) * length) / 4;
                unit = Unit_ComboBox.Text;
                Result_TextBox.Text = result + " " + unit;
            }
        }
    }
}
