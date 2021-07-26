
namespace Volumass.Forms
{
    partial class Mass_Calculation_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mass_Calculation_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Go_To_Main_Menu_Button = new System.Windows.Forms.Button();
            this.Result_TextBox = new System.Windows.Forms.TextBox();
            this.Calculate_Mass_Button = new System.Windows.Forms.Button();
            this.Volume_TextBox = new System.Windows.Forms.TextBox();
            this.Density_TextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Go_To_Main_Menu_Button);
            this.panel1.Controls.Add(this.Result_TextBox);
            this.panel1.Controls.Add(this.Calculate_Mass_Button);
            this.panel1.Controls.Add(this.Volume_TextBox);
            this.panel1.Controls.Add(this.Density_TextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 403);
            this.panel1.TabIndex = 0;
            // 
            // Go_To_Main_Menu_Button
            // 
            this.Go_To_Main_Menu_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Go_To_Main_Menu_Button.FlatAppearance.BorderSize = 0;
            this.Go_To_Main_Menu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Go_To_Main_Menu_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Go_To_Main_Menu_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Go_To_Main_Menu_Button.Location = new System.Drawing.Point(35, 342);
            this.Go_To_Main_Menu_Button.Name = "Go_To_Main_Menu_Button";
            this.Go_To_Main_Menu_Button.Size = new System.Drawing.Size(433, 34);
            this.Go_To_Main_Menu_Button.TabIndex = 4;
            this.Go_To_Main_Menu_Button.Text = "Go Back To Main Menu";
            this.Go_To_Main_Menu_Button.UseVisualStyleBackColor = false;
            this.Go_To_Main_Menu_Button.Click += new System.EventHandler(this.Go_To_Main_Menu_Button_Click);
            // 
            // Result_TextBox
            // 
            this.Result_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Result_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Result_TextBox.Location = new System.Drawing.Point(35, 268);
            this.Result_TextBox.Name = "Result_TextBox";
            this.Result_TextBox.Size = new System.Drawing.Size(433, 27);
            this.Result_TextBox.TabIndex = 3;
            this.Result_TextBox.Text = "  Result:";
            // 
            // Calculate_Mass_Button
            // 
            this.Calculate_Mass_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Calculate_Mass_Button.FlatAppearance.BorderSize = 0;
            this.Calculate_Mass_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate_Mass_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Calculate_Mass_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Calculate_Mass_Button.Location = new System.Drawing.Point(35, 187);
            this.Calculate_Mass_Button.Name = "Calculate_Mass_Button";
            this.Calculate_Mass_Button.Size = new System.Drawing.Size(433, 34);
            this.Calculate_Mass_Button.TabIndex = 2;
            this.Calculate_Mass_Button.Text = "Calculate Mass";
            this.Calculate_Mass_Button.UseVisualStyleBackColor = false;
            this.Calculate_Mass_Button.Click += new System.EventHandler(this.Calculate_Mass_Button_Click);
            // 
            // Volume_TextBox
            // 
            this.Volume_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Volume_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Volume_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Volume_TextBox.Location = new System.Drawing.Point(35, 113);
            this.Volume_TextBox.Name = "Volume_TextBox";
            this.Volume_TextBox.Size = new System.Drawing.Size(433, 27);
            this.Volume_TextBox.TabIndex = 1;
            this.Volume_TextBox.Text = "  Enter Volume";
            this.Volume_TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Volume_TextBox_MouseClick);
            // 
            // Density_TextBox
            // 
            this.Density_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Density_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Density_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(153)))), ((int)(((byte)(244)))));
            this.Density_TextBox.Location = new System.Drawing.Point(35, 39);
            this.Density_TextBox.Name = "Density_TextBox";
            this.Density_TextBox.Size = new System.Drawing.Size(433, 27);
            this.Density_TextBox.TabIndex = 0;
            this.Density_TextBox.Text = "  Enter Density";
            this.Density_TextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Density_TextBox_MouseClick);
            // 
            // Mass_Calculation_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(505, 403);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mass_Calculation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volumass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Density_TextBox;
        private System.Windows.Forms.Button Calculate_Mass_Button;
        private System.Windows.Forms.TextBox Volume_TextBox;
        private System.Windows.Forms.Button Go_To_Main_Menu_Button;
        private System.Windows.Forms.TextBox Result_TextBox;
    }
}