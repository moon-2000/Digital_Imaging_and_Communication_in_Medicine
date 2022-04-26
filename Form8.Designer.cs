
namespace HospitalSystemGUI
{
    partial class Form8
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
            this.PhysicianPortal_label = new System.Windows.Forms.Label();
            this.patientID_label3 = new System.Windows.Forms.Label();
            this.PatientID_lb = new System.Windows.Forms.Label();
            this.medicalInfo_label = new System.Windows.Forms.Label();
            this.ViewRadio_button = new System.Windows.Forms.Button();
            this.labTest_label = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Click_button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.Diagnoses_label = new System.Windows.Forms.Label();
            this.Diagnoses_TB = new System.Windows.Forms.TextBox();
            this.medications_label = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.Prescribe_button = new System.Windows.Forms.Button();
            this.Save_button2 = new System.Windows.Forms.Button();
            this.LogOut_button = new System.Windows.Forms.Button();
            this.Switch_button = new System.Windows.Forms.Button();
            this.MedicalInfo_Grid = new System.Windows.Forms.DataGridView();
            this.BloodPressue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OxyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GluscodeLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RadioTest_label = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalInfo_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // PhysicianPortal_label
            // 
            this.PhysicianPortal_label.AutoSize = true;
            this.PhysicianPortal_label.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhysicianPortal_label.ForeColor = System.Drawing.Color.DarkViolet;
            this.PhysicianPortal_label.Location = new System.Drawing.Point(266, -3);
            this.PhysicianPortal_label.Name = "PhysicianPortal_label";
            this.PhysicianPortal_label.Size = new System.Drawing.Size(284, 46);
            this.PhysicianPortal_label.TabIndex = 0;
            this.PhysicianPortal_label.Text = "Physician Portal ";
            this.PhysicianPortal_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientID_label3
            // 
            this.patientID_label3.AutoSize = true;
            this.patientID_label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientID_label3.Location = new System.Drawing.Point(107, 50);
            this.patientID_label3.Name = "patientID_label3";
            this.patientID_label3.Size = new System.Drawing.Size(96, 28);
            this.patientID_label3.TabIndex = 1;
            this.patientID_label3.Text = "Patient ID";
            // 
            // PatientID_lb
            // 
            this.PatientID_lb.AutoSize = true;
            this.PatientID_lb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientID_lb.Location = new System.Drawing.Point(234, 50);
            this.PatientID_lb.Name = "PatientID_lb";
            this.PatientID_lb.Size = new System.Drawing.Size(105, 28);
            this.PatientID_lb.TabIndex = 2;
            this.PatientID_lb.Text = "#patientID";
            // 
            // medicalInfo_label
            // 
            this.medicalInfo_label.AutoSize = true;
            this.medicalInfo_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medicalInfo_label.Location = new System.Drawing.Point(147, 84);
            this.medicalInfo_label.Name = "medicalInfo_label";
            this.medicalInfo_label.Size = new System.Drawing.Size(168, 28);
            this.medicalInfo_label.TabIndex = 3;
            this.medicalInfo_label.Text = "Basic Medical Info";
            this.medicalInfo_label.Click += new System.EventHandler(this.medicalInfo_label_Click);
            // 
            // ViewRadio_button
            // 
            this.ViewRadio_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewRadio_button.Location = new System.Drawing.Point(565, 365);
            this.ViewRadio_button.Name = "ViewRadio_button";
            this.ViewRadio_button.Size = new System.Drawing.Size(125, 35);
            this.ViewRadio_button.TabIndex = 7;
            this.ViewRadio_button.Text = "View";
            this.ViewRadio_button.UseVisualStyleBackColor = true;
            this.ViewRadio_button.Click += new System.EventHandler(this.ViewRadio_button_Click);
            // 
            // labTest_label
            // 
            this.labTest_label.AccessibleName = "RadioExam_lb";
            this.labTest_label.AutoSize = true;
            this.labTest_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labTest_label.Location = new System.Drawing.Point(107, 297);
            this.labTest_label.Name = "labTest_label";
            this.labTest_label.Size = new System.Drawing.Size(94, 28);
            this.labTest_label.TabIndex = 8;
            this.labTest_label.Text = "Lab Tests ";
            this.labTest_label.Click += new System.EventHandler(this.labTest_label_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(106, 330);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(231, 34);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Click_button2
            // 
            this.Click_button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Click_button2.Location = new System.Drawing.Point(155, 365);
            this.Click_button2.Name = "Click_button2";
            this.Click_button2.Size = new System.Drawing.Size(114, 35);
            this.Click_button2.TabIndex = 10;
            this.Click_button2.Text = "View";
            this.Click_button2.UseVisualStyleBackColor = true;
            this.Click_button2.Click += new System.EventHandler(this.Click_button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lab Tests Done";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(516, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lab Tests Done";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(516, 434);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(232, 34);
            this.listBox4.TabIndex = 14;
            // 
            // Diagnoses_label
            // 
            this.Diagnoses_label.AutoSize = true;
            this.Diagnoses_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Diagnoses_label.Location = new System.Drawing.Point(107, 471);
            this.Diagnoses_label.Name = "Diagnoses_label";
            this.Diagnoses_label.Size = new System.Drawing.Size(102, 28);
            this.Diagnoses_label.TabIndex = 15;
            this.Diagnoses_label.Text = "Diagnoses";
            // 
            // Diagnoses_TB
            // 
            this.Diagnoses_TB.Location = new System.Drawing.Point(106, 502);
            this.Diagnoses_TB.Name = "Diagnoses_TB";
            this.Diagnoses_TB.Size = new System.Drawing.Size(544, 23);
            this.Diagnoses_TB.TabIndex = 16;
            this.Diagnoses_TB.Text = "Include your findngs";
            // 
            // medications_label
            // 
            this.medications_label.AutoSize = true;
            this.medications_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.medications_label.Location = new System.Drawing.Point(106, 528);
            this.medications_label.Name = "medications_label";
            this.medications_label.Size = new System.Drawing.Size(203, 28);
            this.medications_label.TabIndex = 17;
            this.medications_label.Text = "Prescribe Medications";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new System.Drawing.Point(106, 559);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(544, 34);
            this.listBox5.TabIndex = 18;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // Prescribe_button
            // 
            this.Prescribe_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Prescribe_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prescribe_button.Location = new System.Drawing.Point(106, 628);
            this.Prescribe_button.Name = "Prescribe_button";
            this.Prescribe_button.Size = new System.Drawing.Size(120, 37);
            this.Prescribe_button.TabIndex = 19;
            this.Prescribe_button.Text = "Prescribe";
            this.Prescribe_button.UseVisualStyleBackColor = false;
            this.Prescribe_button.Click += new System.EventHandler(this.Prescribe_button_Click);
            // 
            // Save_button2
            // 
            this.Save_button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Save_button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_button2.Location = new System.Drawing.Point(628, 628);
            this.Save_button2.Name = "Save_button2";
            this.Save_button2.Size = new System.Drawing.Size(120, 37);
            this.Save_button2.TabIndex = 20;
            this.Save_button2.Text = "Save";
            this.Save_button2.UseVisualStyleBackColor = false;
            // 
            // LogOut_button
            // 
            this.LogOut_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOut_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOut_button.Location = new System.Drawing.Point(26, 698);
            this.LogOut_button.Name = "LogOut_button";
            this.LogOut_button.Size = new System.Drawing.Size(100, 39);
            this.LogOut_button.TabIndex = 21;
            this.LogOut_button.Text = "Log Out";
            this.LogOut_button.UseVisualStyleBackColor = false;
            this.LogOut_button.Click += new System.EventHandler(this.LogOut_button_Click);
            // 
            // Switch_button
            // 
            this.Switch_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Switch_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Switch_button.Location = new System.Drawing.Point(716, 698);
            this.Switch_button.Name = "Switch_button";
            this.Switch_button.Size = new System.Drawing.Size(100, 39);
            this.Switch_button.TabIndex = 22;
            this.Switch_button.Text = "Swtich";
            this.Switch_button.UseVisualStyleBackColor = false;
            // 
            // MedicalInfo_Grid
            // 
            this.MedicalInfo_Grid.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.MedicalInfo_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicalInfo_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BloodPressue,
            this.OxyLevel,
            this.GluscodeLevel,
            this.Weight,
            this.Date});
            this.MedicalInfo_Grid.Location = new System.Drawing.Point(147, 115);
            this.MedicalInfo_Grid.Name = "MedicalInfo_Grid";
            this.MedicalInfo_Grid.RowTemplate.Height = 25;
            this.MedicalInfo_Grid.Size = new System.Drawing.Size(543, 179);
            this.MedicalInfo_Grid.TabIndex = 23;
            this.MedicalInfo_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicalInfo_Grid_CellContentClick);
            // 
            // BloodPressue
            // 
            this.BloodPressue.HeaderText = "Blood Pressure";
            this.BloodPressue.Name = "BloodPressue";
            this.BloodPressue.ReadOnly = true;
            // 
            // OxyLevel
            // 
            this.OxyLevel.HeaderText = "Oxygen Level";
            this.OxyLevel.Name = "OxyLevel";
            this.OxyLevel.ReadOnly = true;
            // 
            // GluscodeLevel
            // 
            this.GluscodeLevel.HeaderText = "Glucose Level";
            this.GluscodeLevel.Name = "GluscodeLevel";
            this.GluscodeLevel.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date Performed";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(516, 330);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 34);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RadioTest_label
            // 
            this.RadioTest_label.AccessibleName = "RadioExam_lb";
            this.RadioTest_label.AutoSize = true;
            this.RadioTest_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioTest_label.Location = new System.Drawing.Point(516, 297);
            this.RadioTest_label.Name = "RadioTest_label";
            this.RadioTest_label.Size = new System.Drawing.Size(180, 28);
            this.RadioTest_label.TabIndex = 25;
            this.RadioTest_label.Text = "Radiological Exams";
            this.RadioTest_label.Click += new System.EventHandler(this.RadioTest_label_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(106, 434);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(231, 34);
            this.listBox3.TabIndex = 13;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Database_project.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(828, 749);
            this.Controls.Add(this.RadioTest_label);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MedicalInfo_Grid);
            this.Controls.Add(this.Switch_button);
            this.Controls.Add(this.LogOut_button);
            this.Controls.Add(this.Save_button2);
            this.Controls.Add(this.Prescribe_button);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.medications_label);
            this.Controls.Add(this.Diagnoses_TB);
            this.Controls.Add(this.Diagnoses_label);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Click_button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.labTest_label);
            this.Controls.Add(this.ViewRadio_button);
            this.Controls.Add(this.medicalInfo_label);
            this.Controls.Add(this.PatientID_lb);
            this.Controls.Add(this.patientID_label3);
            this.Controls.Add(this.PhysicianPortal_label);
            this.Name = "Form8";
            this.Text = "Physician Portal";
            this.Load += new System.EventHandler(this.Form8_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.MedicalInfo_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhysicianPortal_label;
        private System.Windows.Forms.Label patientID_label3;
        private System.Windows.Forms.Label PatientID_lb;
        private System.Windows.Forms.Label medicalInfo_label;
        private System.Windows.Forms.Button ViewRadio_button;
        private System.Windows.Forms.Label labTest_label;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Click_button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label Diagnoses_label;
        private System.Windows.Forms.TextBox Diagnoses_TB;
        private System.Windows.Forms.Label medications_label;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button Prescribe_button;
        private System.Windows.Forms.Button Save_button2;
        private System.Windows.Forms.Button LogOut_button;
        private System.Windows.Forms.Button Switch_button;
        private System.Windows.Forms.DataGridView MedicalInfo_Grid;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label RadioTest_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodPressue;
        private System.Windows.Forms.DataGridViewTextBoxColumn OxyLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn GluscodeLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.ListBox listBox3;
    }
}