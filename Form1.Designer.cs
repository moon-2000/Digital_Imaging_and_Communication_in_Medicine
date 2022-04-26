
namespace HospitalSystemGUI
{
    partial class Form1
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.PatientId_TB = new System.Windows.Forms.TextBox();
            this.Proceed_button = new System.Windows.Forms.Button();
            this.UserWelcome_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome_label.Location = new System.Drawing.Point(113, 24);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(98, 28);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome ";
            this.welcome_label.Click += new System.EventHandler(this.welcome_label_Click);
            // 
            // PatientId_TB
            // 
            this.PatientId_TB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientId_TB.Location = new System.Drawing.Point(223, 160);
            this.PatientId_TB.Name = "PatientId_TB";
            this.PatientId_TB.Size = new System.Drawing.Size(397, 29);
            this.PatientId_TB.TabIndex = 2;
            this.PatientId_TB.Text = "Patient ID";
            // 
            // Proceed_button
            // 
            this.Proceed_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Proceed_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Proceed_button.ForeColor = System.Drawing.Color.Black;
            this.Proceed_button.Location = new System.Drawing.Point(328, 271);
            this.Proceed_button.Name = "Proceed_button";
            this.Proceed_button.Size = new System.Drawing.Size(159, 38);
            this.Proceed_button.TabIndex = 4;
            this.Proceed_button.Text = "Proceed";
            this.Proceed_button.UseVisualStyleBackColor = false;
            this.Proceed_button.Click += new System.EventHandler(this.Proceed_button_Click);
            // 
            // UserWelcome_lb
            // 
            this.UserWelcome_lb.AutoSize = true;
            this.UserWelcome_lb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserWelcome_lb.Location = new System.Drawing.Point(275, 24); 
            this.UserWelcome_lb.Name = "UserWelcome_lb";
            this.UserWelcome_lb.Size = new System.Drawing.Size(51, 28);
            this.UserWelcome_lb.TabIndex = 5;
            this.UserWelcome_lb.Text = "User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Database_project.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserWelcome_lb);
            this.Controls.Add(this.Proceed_button);
            this.Controls.Add(this.PatientId_TB);
            this.Controls.Add(this.welcome_label);
            this.Name = "Form1";
            this.Text = "Patient ID Portal";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.TextBox PatientId_TB;
        private System.Windows.Forms.Button Proceed_button;
        private System.Windows.Forms.Label UserWelcome_lb;
    }
}