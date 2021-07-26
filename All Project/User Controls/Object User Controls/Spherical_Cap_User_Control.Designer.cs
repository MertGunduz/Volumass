
namespace Volumass.User_Controls.Object_User_Controls
{
    partial class Spherical_Cap_User_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sphere_User_Control_Panel = new System.Windows.Forms.Panel();
            this.Base_Radius_TextBox = new System.Windows.Forms.TextBox();
            this.Ball_Radius_TextBox = new System.Windows.Forms.TextBox();
            this.Result_TextBox = new System.Windows.Forms.TextBox();
            this.Calculate_Volume_Button = new System.Windows.Forms.Button();
            this.Unit_ComboBox = new System.Windows.Forms.ComboBox();
            this.Height_TextBox = new System.Windows.Forms.TextBox();
            this.Sphere_User_Control_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sphere_User_Control_Panel
            // 
            this.Sphere_User_Control_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Sphere_User_Control_Panel.Controls.Add(this.Base_Radius_TextBox);
            this.Sphere_User_Control_Panel.Controls.Add(this.Ball_Radius_TextBox);
            this.Sphere_User_Control_Panel.Controls.Add(this.Result_TextBox);
            this.Sphere_User_Control_Panel.Controls.Add(this.Calculate_Volume_Button);
            this.Sphere_User_Control_Panel.Controls.Add(this.Unit_ComboBox);
            this.Sphere_User_Control_Panel.Controls.Add(this.Height_TextBox);
            this.Sphere_User_Control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sphere_User_Control_Panel.Location = new System.Drawing.Point(0, 0);
            this.Sphere_User_Control_Panel.Name = "Sphere_User_Control_Panel";
            this.Sphere_User_Control_Panel.Size = new System.Drawing.Size(637, 424);
            this.Sphere_User_Control_Panel.TabIndex = 3;
            // 
            // Base_Radius_TextBox
            // 
            this.Base_Radius_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Base_Radius_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Base_Radius_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Base_Radius_TextBox.Location = new System.Drawing.Point(81, 29);
            this.Base_Radius_TextBox.Name = "Base_Radius_TextBox";
            this.Base_Radius_TextBox.Size = new System.Drawing.Size(474, 27);
            this.Base_Radius_TextBox.TabIndex = 5;
            this.Base_Radius_TextBox.Text = "  Enter The Base Radius Of Spherical Cap (r)";
            this.Base_Radius_TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Base_Radius_TextBox_MouseClick);
            // 
            // Ball_Radius_TextBox
            // 
            this.Ball_Radius_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Ball_Radius_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ball_Radius_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Ball_Radius_TextBox.Location = new System.Drawing.Point(81, 73);
            this.Ball_Radius_TextBox.Name = "Ball_Radius_TextBox";
            this.Ball_Radius_TextBox.Size = new System.Drawing.Size(474, 27);
            this.Ball_Radius_TextBox.TabIndex = 4;
            this.Ball_Radius_TextBox.Text = "  Enter The Ball Radius Of Spherical Cap (R)";
            this.Ball_Radius_TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Ball_Radius_TextBox_MouseClick);
            // 
            // Result_TextBox
            // 
            this.Result_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Result_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Result_TextBox.Location = new System.Drawing.Point(81, 313);
            this.Result_TextBox.Name = "Result_TextBox";
            this.Result_TextBox.Size = new System.Drawing.Size(474, 27);
            this.Result_TextBox.TabIndex = 3;
            this.Result_TextBox.Text = "  Result: ";
            // 
            // Calculate_Volume_Button
            // 
            this.Calculate_Volume_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Calculate_Volume_Button.FlatAppearance.BorderSize = 0;
            this.Calculate_Volume_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate_Volume_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Calculate_Volume_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Calculate_Volume_Button.Location = new System.Drawing.Point(81, 235);
            this.Calculate_Volume_Button.Name = "Calculate_Volume_Button";
            this.Calculate_Volume_Button.Size = new System.Drawing.Size(474, 33);
            this.Calculate_Volume_Button.TabIndex = 2;
            this.Calculate_Volume_Button.Text = "Calculate The Volume";
            this.Calculate_Volume_Button.UseVisualStyleBackColor = false;
            this.Calculate_Volume_Button.Click += new System.EventHandler(this.Calculate_Volume_Button_Click);
            // 
            // Unit_ComboBox
            // 
            this.Unit_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Unit_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unit_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Unit_ComboBox.FormattingEnabled = true;
            this.Unit_ComboBox.Items.AddRange(new object[] {
            "Kilometers",
            "Meters",
            "Centimeters",
            "Milimeters",
            "Micrometers",
            "Nanometers"});
            this.Unit_ComboBox.Location = new System.Drawing.Point(81, 161);
            this.Unit_ComboBox.Name = "Unit_ComboBox";
            this.Unit_ComboBox.Size = new System.Drawing.Size(474, 29);
            this.Unit_ComboBox.TabIndex = 1;
            this.Unit_ComboBox.Text = "  Select The Unit Of Length";
            // 
            // Height_TextBox
            // 
            this.Height_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Height_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Height_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Height_TextBox.Location = new System.Drawing.Point(81, 117);
            this.Height_TextBox.Name = "Height_TextBox";
            this.Height_TextBox.Size = new System.Drawing.Size(474, 27);
            this.Height_TextBox.TabIndex = 0;
            this.Height_TextBox.Text = "  Enter The Height Of Spherical Cap (h)";
            this.Height_TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Height_TextBox_MouseClick);
            // 
            // Spherical_Cap_User_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Sphere_User_Control_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Spherical_Cap_User_Control";
            this.Size = new System.Drawing.Size(637, 424);
            this.Sphere_User_Control_Panel.ResumeLayout(false);
            this.Sphere_User_Control_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sphere_User_Control_Panel;
        private System.Windows.Forms.TextBox Base_Radius_TextBox;
        private System.Windows.Forms.TextBox Ball_Radius_TextBox;
        private System.Windows.Forms.TextBox Result_TextBox;
        private System.Windows.Forms.Button Calculate_Volume_Button;
        private System.Windows.Forms.ComboBox Unit_ComboBox;
        private System.Windows.Forms.TextBox Height_TextBox;
    }
}
