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
    public partial class Cube_User_Control : UserControl
    {

        double edgeLength;
        double result;
        string unit;

        public Cube_User_Control()
        {
            InitializeComponent();
        }

        private void Edge_Length_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Edge_Length_TextBox.Text == "  Enter The Edge Length Of Cube (a)")
            {
                Edge_Length_TextBox.Clear();
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
                edgeLength = Convert.ToDouble(Edge_Length_TextBox.Text);
                result = Math.Pow(edgeLength, 3);
                unit = Unit_ComboBox.Text;
                Result_TextBox.Text = result.ToString() + " " + unit; 
            }
        }
    }
}
