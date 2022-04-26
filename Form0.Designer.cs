
namespace HospitalSystemGUI
{
    partial class Form0
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.Username_TB = new System.Windows.Forms.TextBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.ForgetPassword_button = new System.Windows.Forms.Button();
            this.Username_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username_TB
            // 
            this.Username_TB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username_TB.Location = new System.Drawing.Point(151, 55);
            this.Username_TB.Name = "Username_TB";
            this.Username_TB.Size = new System.Drawing.Size(212, 29);
            this.Username_TB.TabIndex = 0;
            this.Username_TB.Text = "Username";
            this.Username_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password_TB
            // 
            this.Password_TB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_TB.Location = new System.Drawing.Point(151, 136);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(212, 29);
            this.Password_TB.TabIndex = 1;
            this.Password_TB.Text = "Password";
            this.Password_TB.TextChanged += new System.EventHandler(this.Password_TB_TextChanged);
            // 
            // LogIn_button
            // 
            this.LogIn_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogIn_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogIn_button.Location = new System.Drawing.Point(192, 253);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(122, 37);
            this.LogIn_button.TabIndex = 2;
            this.LogIn_button.Text = "Log in";
            this.LogIn_button.UseVisualStyleBackColor = false;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // ForgetPassword_button
            // 
            this.ForgetPassword_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ForgetPassword_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ForgetPassword_button.ForeColor = System.Drawing.Color.Black;
            this.ForgetPassword_button.Location = new System.Drawing.Point(151, 343);
            this.ForgetPassword_button.Name = "ForgetPassword_button";
            this.ForgetPassword_button.Size = new System.Drawing.Size(212, 31);
            this.ForgetPassword_button.TabIndex = 3;
            this.ForgetPassword_button.Text = "ForgetPassword";
            this.ForgetPassword_button.UseVisualStyleBackColor = false;
            this.ForgetPassword_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(314, 55);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(0, 15);
            this.Username_label.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(492, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.ForgetPassword_button);
            this.Controls.Add(this.LogIn_button);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.Username_TB);
            this.Name = "Form0";
            this.Text = "Sign in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.Button ForgetPassword_button;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Username_TB;
    }
}

