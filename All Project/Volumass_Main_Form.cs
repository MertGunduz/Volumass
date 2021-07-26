using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumass
{
    public partial class Volumass_Main_Form : Form
    {
        public Volumass_Main_Form()
        {
            InitializeComponent();
        }

        private void Volumass_Main_Form_Load(object sender, EventArgs e)
        {
            SubPanel_Objects.Visible = false;
            Main_Heading_Label.Text = "Volumass";
        }

        private void Objects_Button_Click(object sender, EventArgs e)
        {
            // Color Changing 
            if (Objects_Button.BackColor == Color.FromArgb(24, 30, 54))
            {
                Objects_Button.BackColor = Color.FromArgb(46, 51, 73);
                Settings_Button.BackColor = Color.FromArgb(24, 30, 54);
            }
            else if (Objects_Button.BackColor == Color.FromArgb(46, 51, 73))
            {
                Objects_Button.BackColor = Color.FromArgb(24, 30, 54);
                Settings_Button.BackColor = Color.FromArgb(24, 30, 54);
            }

            // Subpanel Opening & Closing
            if (SubPanel_Objects.Visible == true)
            {
                SubPanel_Objects.Visible = false;
                Main_Heading_Label.Text = "";
                Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                main_Menu_User_Control1.BringToFront();
                Main_Heading_Label.Text = "Volumass";
            }
            else if (SubPanel_Objects.Visible == false)
            {
                Main_Heading_Label.Text = "Objects";
                SubPanel_Objects.Visible = true;
                Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
                Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            }
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            // Color Changing
            Objects_Button.BackColor = Color.FromArgb(24, 30, 54);
            Settings_Button.BackColor = Color.FromArgb(46, 51, 73);
            Main_Heading_Label.Text = "Settings";
            settings_User_Control1.BringToFront();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sphere_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Sphere";
            Sphere_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            sphere_User_Control1.BringToFront();
        }

        private void Cone_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Cone";
            Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cone_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            cone_User_Control1.BringToFront();
        }

        private void Cube_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Cube";
            Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cube_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            cube_User_Control1.BringToFront();
        }

        private void Cylinder_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Cylinder";
            Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cylinder_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            cylinder_User_Control1.BringToFront();
        }

        private void RectangularTank_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Rectangular Tank";
            Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            RectangularTank_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            rectangular_Tank_User_Control1.BringToFront();
        }

        private void Capusle_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Capsule";
            Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Capusle_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            capsule_User_Control1.BringToFront();
        }

        private void SphericalCap_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Spherical Cap";
            Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            SphericalCap_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            spherical_Cap_User_Control1.BringToFront();
        }

        private void ConicalFrustum_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Conical Frustum";
            Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            conical_Frustum_User_Control1.BringToFront();
        }

        private void Ellipsoid_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Ellipsoid";
            Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ellipsoid_User_Control1.BringToFront();
        }

        private void Square_Pyramid_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Square Pyramid";
            Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            Tube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            square_Pyramid_User_Control1.BringToFront();
        }

        private void Tube_SubButton_Click(object sender, EventArgs e)
        {
            Main_Heading_Label.Text = "Tube";
            Sphere_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cone_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cube_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Cylinder_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            RectangularTank_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Capusle_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            SphericalCap_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            ConicalFrustum_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Ellipsoid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Square_Pyramid_SubButton.BackColor = Color.FromArgb(24, 30, 54);
            Tube_SubButton.BackColor = Color.FromArgb(46, 51, 73);
            tube_User_Control1.BringToFront();
        }

        private void Open_The_Mass_Calculator_Menu_Click(object sender, EventArgs e)
        {
            Forms.Mass_Calculation_Form massForm = new Forms.Mass_Calculation_Form();
            this.Hide();
            massForm.Show();
        }
    }
}
