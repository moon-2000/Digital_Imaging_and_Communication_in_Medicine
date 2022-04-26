namespace HospitalSystemGUI
{
    partial class Form11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPass_TB = new System.Windows.Forms.TextBox();
            this.Proceed_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(310, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recover your password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kindly enter your new password:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // NewPass_TB
            // 
            this.NewPass_TB.Location = new System.Drawing.Point(398, 178);
            this.NewPass_TB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NewPass_TB.Name = "NewPass_TB";
            this.NewPass_TB.Size = new System.Drawing.Size(311, 23);
            this.NewPass_TB.TabIndex = 6;
            this.NewPass_TB.Text = "New Password";
            this.NewPass_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Proceed_button
            // 
            this.Proceed_button.Location = new System.Drawing.Point(318, 314);
            this.Proceed_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Proceed_button.Name = "Proceed_button";
            this.Proceed_button.Size = new System.Drawing.Size(326, 96);
            this.Proceed_button.TabIndex = 7;
            this.Proceed_button.Text = "Proceed";
            this.Proceed_button.UseVisualStyleBackColor = true;
            this.Proceed_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Database_project.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.Proceed_button);
            this.Controls.Add(this.NewPass_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form11";
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPass_TB;
        private System.Windows.Forms.Button Proceed_button;
    }
}