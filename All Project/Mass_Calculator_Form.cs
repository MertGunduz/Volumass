using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumass.Forms
{
    public partial class Mass_Calculation_Form : Form
    {

        double density;
        double volume;
        double result;

        public Mass_Calculation_Form()
        {
            InitializeComponent();
        }

        private void Density_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Density_TextBox.Text == "  Enter Density")
            {
                Density_TextBox.Clear();
            }
        }

        private void Volume_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Volume_TextBox.Text == "  Enter Volume")
            {
                Volume_TextBox.Clear();
            }
        }

        private void Calculate_Mass_Button_Click(object sender, EventArgs e)
        {
            density = Convert.ToDouble(Density_TextBox.Text);
            volume = Convert.ToDouble(Volume_TextBox.Text);
            result = density * volume;
            Result_TextBox.Text = result.ToString();
        }

        private void Go_To_Main_Menu_Button_Click(object sender, EventArgs e)
        {
            Volumass_Main_Form volumassForm = new Volumass_Main_Form();
            this.Hide();
            volumassForm.Show();
        }
    }
}
