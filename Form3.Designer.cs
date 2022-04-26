
namespace HospitalSystemGUI
{
    partial class Form3
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
            this.RadioPortal_label = new System.Windows.Forms.Label();
            this.patientId_label = new System.Windows.Forms.Label();
            this.PatientID_lb = new System.Windows.Forms.Label();
            this.ExamName_label = new System.Windows.Forms.Label();
            this.RadioNameListBox = new System.Windows.Forms.ListBox();
            this.RadioImage_Box = new System.Windows.Forms.PictureBox();
            this.InsertImage_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.Log_button = new System.Windows.Forms.Button();
            this.Switch_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RadiologistReportTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RadioImage_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioPortal_label
            // 
            this.RadioPortal_label.AutoSize = true;
            this.RadioPortal_label.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RadioPortal_label.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RadioPortal_label.ForeColor = System.Drawing.Color.DarkCyan;
            this.RadioPortal_label.Location = new System.Drawing.Point(228, -2);
            this.RadioPortal_label.Name = "RadioPortal_label";
            this.RadioPortal_label.Size = new System.Drawing.Size(317, 46);
            this.RadioPortal_label.TabIndex = 0;
            this.RadioPortal_label.Text = "Radiologist Portal ";
            this.RadioPortal_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientId_label
            // 
            this.patientId_label.AutoSize = true;
            this.patientId_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientId_label.Location = new System.Drawing.Point(14, 70);
            this.patientId_label.Name = "patientId_label";
            this.patientId_label.Size = new System.Drawing.Size(96, 28);
            this.patientId_label.TabIndex = 1;
            this.patientId_label.Text = "Patient ID";
            // 
            // PatientID_lb
            // 
            this.PatientID_lb.AutoSize = true;
            this.PatientID_lb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientID_lb.Location = new System.Drawing.Point(169, 70);
            this.PatientID_lb.Name = "PatientID_lb";
            this.PatientID_lb.Size = new System.Drawing.Size(0, 28);
            this.PatientID_lb.TabIndex = 2;
            this.PatientID_lb.Click += new System.EventHandler(this.PatientID_label2_Click);
            // 
            // ExamName_label
            // 
            this.ExamName_label.AutoSize = true;
            this.ExamName_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExamName_label.Location = new System.Drawing.Point(12, 117);
            this.ExamName_label.Name = "ExamName_label";
            this.ExamName_label.Size = new System.Drawing.Size(176, 28);
            this.ExamName_label.TabIndex = 3;
            this.ExamName_label.Text = "Examination Name";
            this.ExamName_label.Click += new System.EventHandler(this.ExamName_label_Click);
            // 
            // RadioNameListBox
            // 
            this.RadioNameListBox.FormattingEnabled = true;
            this.RadioNameListBox.ItemHeight = 15;
            this.RadioNameListBox.Items.AddRange(new object[] {
            "Positron Emission Tomography ( PMT )",
            "Magnetic Resonance Imaging ( MRI )",
            "Computed Tomography ( CT )",
            "Bone Density Scan ( DEXA )",
            "Wellness Screening",
            "Breast Imaging ",
            "Pediatrics ",
            "Ultrasound ",
            "X-ray "});
            this.RadioNameListBox.Location = new System.Drawing.Point(12, 150);
            this.RadioNameListBox.Name = "RadioNameListBox";
            this.RadioNameListBox.Size = new System.Drawing.Size(320, 109);
            this.RadioNameListBox.TabIndex = 4;
            this.RadioNameListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RadioImage_Box
            // 
            this.RadioImage_Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadioImage_Box.Location = new System.Drawing.Point(456, 148);
            this.RadioImage_Box.Name = "RadioImage_Box";
            this.RadioImage_Box.Size = new System.Drawing.Size(339, 174);
            this.RadioImage_Box.TabIndex = 5;
            this.RadioImage_Box.TabStop = false;
            this.RadioImage_Box.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InsertImage_label
            // 
            this.InsertImage_label.AutoSize = true;
            this.InsertImage_label.Enabled = false;
            this.InsertImage_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertImage_label.Location = new System.Drawing.Point(456, 117);
            this.InsertImage_label.Name = "InsertImage_label";
            this.InsertImage_label.Size = new System.Drawing.Size(152, 28);
            this.InsertImage_label.TabIndex = 6;
            this.InsertImage_label.Text = "Insert the image";
            this.InsertImage_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.DarkCyan;
            this.Save_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Location = new System.Drawing.Point(351, 373);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 43);
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Log_button
            // 
            this.Log_button.BackColor = System.Drawing.Color.DarkCyan;
            this.Log_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Log_button.ForeColor = System.Drawing.Color.White;
            this.Log_button.Location = new System.Drawing.Point(14, 426);
            this.Log_button.Name = "Log_button";
            this.Log_button.Size = new System.Drawing.Size(116, 36);
            this.Log_button.TabIndex = 8;
            this.Log_button.Text = "Log Out ?";
            this.Log_button.UseVisualStyleBackColor = false;
            this.Log_button.Click += new System.EventHandler(this.Log_button_Click);
            // 
            // Switch_button
            // 
            this.Switch_button.BackColor = System.Drawing.Color.DarkCyan;
            this.Switch_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Switch_button.ForeColor = System.Drawing.Color.White;
            this.Switch_button.Location = new System.Drawing.Point(645, 426);
            this.Switch_button.Name = "Switch_button";
            this.Switch_button.Size = new System.Drawing.Size(116, 36);
            this.Switch_button.TabIndex = 9;
            this.Switch_button.Text = "Switch ";
            this.Switch_button.UseVisualStyleBackColor = false;
            this.Switch_button.Click += new System.EventHandler(this.Switch_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Radiologist\'s Report";
            // 
            // RadiologistReportTB
            // 
            this.RadiologistReportTB.Location = new System.Drawing.Point(12, 293);
            this.RadiologistReportTB.Name = "RadiologistReportTB";
            this.RadiologistReportTB.Size = new System.Drawing.Size(320, 23);
            this.RadiologistReportTB.TabIndex = 11;
            this.RadiologistReportTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(599, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Database_project.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RadiologistReportTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Switch_button);
            this.Controls.Add(this.Log_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.InsertImage_label);
            this.Controls.Add(this.RadioImage_Box);
            this.Controls.Add(this.RadioNameListBox);
            this.Controls.Add(this.ExamName_label);
            this.Controls.Add(this.PatientID_lb);
            this.Controls.Add(this.patientId_label);
            this.Controls.Add(this.RadioPortal_label);
            this.Name = "Form3";
            this.Text = "Radiologist Portal";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RadioImage_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RadioPortal_label;
        private System.Windows.Forms.Label patientId_label;
        private System.Windows.Forms.Label PatientID_label2;
        private System.Windows.Forms.Label ExamName_label;
        private System.Windows.Forms.ListBox RadioNameListBox;
        private System.Windows.Forms.PictureBox RadioImage_Box;
        private System.Windows.Forms.Label InsertImage_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Log_button;
        private System.Windows.Forms.Button Switch_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RadiologistReportTB;
        private System.Windows.Forms.Label PatientID_lb;
    }
}