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
    public partial class Square_Pyramid_User_Control : UserControl
    {
        double sigNumber = 0.3333;
        double baseEdge;
        double height;
        double result;
        string unit;

        public Square_Pyramid_User_Control()
        {
            InitializeComponent();
        }

        private void Base_Edge_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Base_Edge_TextBox.Text == "  Enter The Base Edge Of Square Pyramid (a)")
            {
                Base_Edge_TextBox.Clear();
            }
        }

        private void Height_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Height_TextBox.Text == "  Enter The Height Of Square Pyramid (h)")
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
                baseEdge = Convert.ToDouble(Base_Edge_TextBox.Text);
                height = Convert.ToDouble(Height_TextBox.Text);
                result = sigNumber * Math.Pow(baseEdge, 2) * height;
                unit = Unit_ComboBox.Text;
                Result_TextBox.Text = result + " " + unit;
            }
        }
    }
}
