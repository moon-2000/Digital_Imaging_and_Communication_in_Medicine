
namespace HospitalSystemGUI 
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.NursingPortal_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PatientID_labelvar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bloodpress_TB = new System.Windows.Forms.TextBox();
            this.BloodGlucose_TB = new System.Windows.Forms.TextBox();
            this.BloodPressureLabel = new System.Windows.Forms.Label();
            this.OxygenLevel_Label = new System.Windows.Forms.Label();
            this.OxegyenLevel_TB = new System.Windows.Forms.TextBox();
            this.Weight_TB = new System.Windows.Forms.TextBox();
            this.BloodGlucose_label = new System.Windows.Forms.Label();
            this.Height_TB = new System.Windows.Forms.TextBox();
            this.MeasuredWeight_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.Switch_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MedicalHistory_listBox = new System.Windows.Forms.ListBox();
            this.patientID_label = new System.Windows.Forms.Label();
            this.Height_label = new System.Windows.Forms.Label();
            this.MedicalHistory_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NursingPortal_label
            // 
            this.NursingPortal_label.AutoSize = true;
            this.NursingPortal_label.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NursingPortal_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NursingPortal_label.Location = new System.Drawing.Point(214, 1);
            this.NursingPortal_label.Name = "NursingPortal_label";
            this.NursingPortal_label.Size = new System.Drawing.Size(298, 54);
            this.NursingPortal_label.TabIndex = 0;
            this.NursingPortal_label.Text = "Nursing Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 55);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            
            // 
            // PatientID_labelvar
            // 
            this.PatientID_labelvar.AutoSize = true;
            this.PatientID_labelvar.Location = new System.Drawing.Point(292, 69);
            this.PatientID_labelvar.Name = "PatientID_labelvar";
            this.PatientID_labelvar.Size = new System.Drawing.Size(61, 15);
            this.PatientID_labelvar.TabIndex = 2;
            this.PatientID_labelvar.Text = "#patientId";
          
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Patient ID";
            // 
            // bloodpress_TB
            // 
            this.bloodpress_TB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bloodpress_TB.Location = new System.Drawing.Point(41, 160);
            this.bloodpress_TB.Name = "bloodpress_TB";
            this.bloodpress_TB.Size = new System.Drawing.Size(263, 34);
            this.bloodpress_TB.TabIndex = 4;
            // 
            // BloodGlucose_TB
            // 
            this.BloodGlucose_TB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloodGlucose_TB.Location = new System.Drawing.Point(416, 161);
            this.BloodGlucose_TB.Name = "BloodGlucose_TB";
            this.BloodGlucose_TB.Size = new System.Drawing.Size(312, 34);
            this.BloodGlucose_TB.TabIndex = 6;
            // 
            // BloodPressureLabel
            // 
            this.BloodPressureLabel.AutoSize = true;
            this.BloodPressureLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloodPressureLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.BloodPressureLabel.Location = new System.Drawing.Point(41, 131);
            this.BloodPressureLabel.Name = "BloodPressureLabel";
            this.BloodPressureLabel.Size = new System.Drawing.Size(187, 21);
            this.BloodPressureLabel.TabIndex = 5;
            this.BloodPressureLabel.Text = "Measured Blood Pressure";
            this.BloodPressureLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OxygenLevel_Label
            // 
            this.OxygenLevel_Label.AutoSize = true;
            this.OxygenLevel_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OxygenLevel_Label.ForeColor = System.Drawing.Color.BlueViolet;
            this.OxygenLevel_Label.Location = new System.Drawing.Point(41, 225);
            this.OxygenLevel_Label.Name = "OxygenLevel_Label";
            this.OxygenLevel_Label.Size = new System.Drawing.Size(172, 21);
            this.OxygenLevel_Label.TabIndex = 7;
            this.OxygenLevel_Label.Text = "Measured Oxygen level";
            // 
            // OxegyenLevel_TB
            // 
            this.OxegyenLevel_TB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OxegyenLevel_TB.Location = new System.Drawing.Point(41, 254);
            this.OxegyenLevel_TB.Name = "OxegyenLevel_TB";
            this.OxegyenLevel_TB.Size = new System.Drawing.Size(263, 34);
            this.OxegyenLevel_TB.TabIndex = 10;
            // 
            // Weight_TB
            // 
            this.Weight_TB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Weight_TB.Location = new System.Drawing.Point(41, 355);
            this.Weight_TB.Name = "Weight_TB";
            this.Weight_TB.Size = new System.Drawing.Size(263, 34);
            this.Weight_TB.TabIndex = 12;
            // 
            // BloodGlucose_label
            // 
            this.BloodGlucose_label.AutoSize = true;
            this.BloodGlucose_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BloodGlucose_label.ForeColor = System.Drawing.Color.BlueViolet;
            this.BloodGlucose_label.Location = new System.Drawing.Point(416, 131);
            this.BloodGlucose_label.Name = "BloodGlucose_label";
            this.BloodGlucose_label.Size = new System.Drawing.Size(182, 21);
            this.BloodGlucose_label.TabIndex = 11;
            this.BloodGlucose_label.Text = "Measured Blood Glucose";
            // 
            // Height_TB
            // 
            this.Height_TB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Height_TB.Location = new System.Drawing.Point(416, 254);
            this.Height_TB.Name = "Height_TB";
            this.Height_TB.Size = new System.Drawing.Size(312, 34);
            this.Height_TB.TabIndex = 14;
            // 
            // MeasuredWeight_label
            // 
            this.MeasuredWeight_label.AutoSize = true;
            this.MeasuredWeight_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MeasuredWeight_label.ForeColor = System.Drawing.Color.BlueViolet;
            this.MeasuredWeight_label.Location = new System.Drawing.Point(41, 330);
            this.MeasuredWeight_label.Name = "MeasuredWeight_label";
            this.MeasuredWeight_label.Size = new System.Drawing.Size(132, 21);
            this.MeasuredWeight_label.TabIndex = 13;
            this.MeasuredWeight_label.Text = "Measured Weight";
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Save_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Location = new System.Drawing.Point(316, 411);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(86, 43);
            this.Save_button.TabIndex = 15;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Switch_button
            // 
            this.Switch_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Switch_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Switch_button.ForeColor = System.Drawing.Color.White;
            this.Switch_button.Location = new System.Drawing.Point(530, 476);
            this.Switch_button.Name = "Switch_button";
            this.Switch_button.Size = new System.Drawing.Size(107, 36);
            this.Switch_button.TabIndex = 16;
            this.Switch_button.Text = "Switch";
            this.Switch_button.UseVisualStyleBackColor = false;
            this.Switch_button.Click += new System.EventHandler(this.Switch_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(87, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 17;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MedicalHistory_listBox
            // 
            this.MedicalHistory_listBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedicalHistory_listBox.FormattingEnabled = true;
            this.MedicalHistory_listBox.ItemHeight = 28;
            this.MedicalHistory_listBox.Items.AddRange(new object[] {
            "AlZaheimer ",
            "Diabetes",
            "Heart Disease",
            "Obesity ",
            "Cancer ",
            "Arthritis",
            "Others"});
            this.MedicalHistory_listBox.Location = new System.Drawing.Point(416, 356);
            this.MedicalHistory_listBox.Name = "MedicalHistory_listBox";
            this.MedicalHistory_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.MedicalHistory_listBox.Size = new System.Drawing.Size(312, 32);
            this.MedicalHistory_listBox.TabIndex = 18;
            // 
            // patientID_label
            // 
            this.patientID_label.AutoSize = true;
            this.patientID_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientID_label.ForeColor = System.Drawing.Color.Black;
            this.patientID_label.Location = new System.Drawing.Point(163, 72);
            this.patientID_label.Name = "patientID_label";
            this.patientID_label.Size = new System.Drawing.Size(0, 28);
            this.patientID_label.TabIndex = 9;
            this.patientID_label.Click += new System.EventHandler(this.label7_Click);
            // 
            // Height_label
            // 
            this.Height_label.AutoSize = true;
            this.Height_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Height_label.ForeColor = System.Drawing.Color.BlueViolet;
            this.Height_label.Location = new System.Drawing.Point(416, 221);
            this.Height_label.Name = "Height_label";
            this.Height_label.Size = new System.Drawing.Size(129, 21);
            this.Height_label.TabIndex = 19;
            this.Height_label.Text = "Measured Height";
            // 
            // MedicalHistory_label
            // 
            this.MedicalHistory_label.AutoSize = true;
            this.MedicalHistory_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedicalHistory_label.ForeColor = System.Drawing.Color.BlueViolet;
            this.MedicalHistory_label.Location = new System.Drawing.Point(416, 330);
            this.MedicalHistory_label.Name = "MedicalHistory_label";
            this.MedicalHistory_label.Size = new System.Drawing.Size(118, 21);
            this.MedicalHistory_label.TabIndex = 20;
            this.MedicalHistory_label.Text = "Medical History";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(762, 524);
            this.Controls.Add(this.MedicalHistory_label);
            this.Controls.Add(this.Height_label);
            this.Controls.Add(this.MedicalHistory_listBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Switch_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Height_TB);
            this.Controls.Add(this.MeasuredWeight_label);
            this.Controls.Add(this.Weight_TB);
            this.Controls.Add(this.BloodGlucose_label);
            this.Controls.Add(this.OxegyenLevel_TB);
            this.Controls.Add(this.patientID_label);
            this.Controls.Add(this.OxygenLevel_Label);
            this.Controls.Add(this.BloodGlucose_TB);
            this.Controls.Add(this.BloodPressureLabel);
            this.Controls.Add(this.bloodpress_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NursingPortal_label);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Nursing Portal";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NursingPortal_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PatientID_labelvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bloodpress_TB;
        private System.Windows.Forms.TextBox BloodGlucose_TB;
        private System.Windows.Forms.Label BloodPressureLabel;
        private System.Windows.Forms.Label OxygenLevel_Label;
        private System.Windows.Forms.TextBox OxegyenLevel_TB;
        private System.Windows.Forms.TextBox Weight_TB;
        private System.Windows.Forms.Label BloodGlucose_label;
        private System.Windows.Forms.TextBox Height_TB;
        private System.Windows.Forms.Label MeasuredWeight_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Switch_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox MedicalHistory_listBox;
        private System.Windows.Forms.Label patientID_label;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label Height_label;
        private System.Windows.Forms.Label MedicalHistory_label;
    }
}