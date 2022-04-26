
namespace HospitalSystemGUI
{
    partial class Form4
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
            this.PatientID_label = new System.Windows.Forms.Label();
            this.PatientID_label2 = new System.Windows.Forms.Label();
            this.Examination_Label = new System.Windows.Forms.Label();
            this.ExaminationName_listBox1 = new System.Windows.Forms.ListBox();
            this.InsertTest_Label = new System.Windows.Forms.Label();
            this.Hemologist_label = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Switch_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LabtestResultsPictureBox = new System.Windows.Forms.PictureBox();
            this.Pid_lb = new System.Windows.Forms.Label();
            this.Hemo_TB = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LabtestResultsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(301, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab Portal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PatientID_label
            // 
            this.PatientID_label.AutoSize = true;
            this.PatientID_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientID_label.Location = new System.Drawing.Point(36, 59);
            this.PatientID_label.Name = "PatientID_label";
            this.PatientID_label.Size = new System.Drawing.Size(91, 28);
            this.PatientID_label.TabIndex = 1;
            this.PatientID_label.Text = "PatientID";
            // 
            // PatientID_label2
            // 
            this.PatientID_label2.AutoSize = true;
            this.PatientID_label2.Location = new System.Drawing.Point(229, 59);
            this.PatientID_label2.Name = "PatientID_label2";
            this.PatientID_label2.Size = new System.Drawing.Size(0, 15);
            this.PatientID_label2.TabIndex = 2;
            this.PatientID_label2.Click += new System.EventHandler(this.PatientID_label2_Click);
            // 
            // Examination_Label
            // 
            this.Examination_Label.AutoSize = true;
            this.Examination_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Examination_Label.Location = new System.Drawing.Point(36, 97);
            this.Examination_Label.Name = "Examination_Label";
            this.Examination_Label.Size = new System.Drawing.Size(181, 28);
            this.Examination_Label.TabIndex = 3;
            this.Examination_Label.Text = "Examination  Name";
            // 
            // ExaminationName_listBox1
            // 
            this.ExaminationName_listBox1.FormattingEnabled = true;
            this.ExaminationName_listBox1.ItemHeight = 15;
            this.ExaminationName_listBox1.Items.AddRange(new object[] {
            "Hemoglobin A1C",
            "Urinalysis",
            "Cultures",
            "Complete Blood Count",
            "Comprehensive Metabolic Panel",
            "Lipid Panel",
            "Prothrombin Time"});
            this.ExaminationName_listBox1.Location = new System.Drawing.Point(36, 128);
            this.ExaminationName_listBox1.Name = "ExaminationName_listBox1";
            this.ExaminationName_listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ExaminationName_listBox1.Size = new System.Drawing.Size(221, 79);
            this.ExaminationName_listBox1.TabIndex = 4;
            // 
            // InsertTest_Label
            // 
            this.InsertTest_Label.AutoSize = true;
            this.InsertTest_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertTest_Label.Location = new System.Drawing.Point(471, 88);
            this.InsertTest_Label.Name = "InsertTest_Label";
            this.InsertTest_Label.Size = new System.Drawing.Size(163, 28);
            this.InsertTest_Label.TabIndex = 5;
            this.InsertTest_Label.Text = "Insert Test Results";
            // 
            // Hemologist_label
            // 
            this.Hemologist_label.AutoSize = true;
            this.Hemologist_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hemologist_label.Location = new System.Drawing.Point(36, 217);
            this.Hemologist_label.Name = "Hemologist_label";
            this.Hemologist_label.Size = new System.Drawing.Size(191, 28);
            this.Hemologist_label.TabIndex = 7;
            this.Hemologist_label.Text = "Hemologist\'s Report";
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.Color.Red;
            this.Save_Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save_Button.ForeColor = System.Drawing.Color.White;
            this.Save_Button.Location = new System.Drawing.Point(351, 359);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 43);
            this.Save_Button.TabIndex = 9;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Switch_button
            // 
            this.Switch_button.BackColor = System.Drawing.Color.Red;
            this.Switch_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Switch_button.ForeColor = System.Drawing.Color.White;
            this.Switch_button.Location = new System.Drawing.Point(650, 411);
            this.Switch_button.Name = "Switch_button";
            this.Switch_button.Size = new System.Drawing.Size(116, 36);
            this.Switch_button.TabIndex = 10;
            this.Switch_button.Text = "Switch";
            this.Switch_button.UseVisualStyleBackColor = false;
            this.Switch_button.Click += new System.EventHandler(this.Switch_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(34, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Log out?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LabtestResultsPictureBox
            // 
            this.LabtestResultsPictureBox.Location = new System.Drawing.Point(471, 119);
            this.LabtestResultsPictureBox.Name = "LabtestResultsPictureBox";
            this.LabtestResultsPictureBox.Size = new System.Drawing.Size(295, 229);
            this.LabtestResultsPictureBox.TabIndex = 12;
            this.LabtestResultsPictureBox.TabStop = false;
            // 
            // Pid_lb
            // 
            this.Pid_lb.AutoSize = true;
            this.Pid_lb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pid_lb.Location = new System.Drawing.Point(260, 53);
            this.Pid_lb.Name = "Pid_lb";
            this.Pid_lb.Size = new System.Drawing.Size(17, 28);
            this.Pid_lb.TabIndex = 13;
            this.Pid_lb.Text = "l";
            // 
            // Hemo_TB
            // 
            this.Hemo_TB.Location = new System.Drawing.Point(36, 252);
            this.Hemo_TB.Name = "Hemo_TB";
            this.Hemo_TB.Size = new System.Drawing.Size(221, 96);
            this.Hemo_TB.TabIndex = 14;
            this.Hemo_TB.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Database_project.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hemo_TB);
            this.Controls.Add(this.Pid_lb);
            this.Controls.Add(this.LabtestResultsPictureBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Switch_button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Hemologist_label);
            this.Controls.Add(this.InsertTest_Label);
            this.Controls.Add(this.ExaminationName_listBox1);
            this.Controls.Add(this.Examination_Label);
            this.Controls.Add(this.PatientID_label2);
            this.Controls.Add(this.PatientID_label);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Lab Portal";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LabtestResultsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PatientID_label;
        private System.Windows.Forms.Label PatientID_label2;
        private System.Windows.Forms.Label Examination_Label;
        private System.Windows.Forms.ListBox ExaminationName_listBox1;
        private System.Windows.Forms.Label InsertTest_Label;
        private System.Windows.Forms.Label Hemologist_label;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Switch_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox LabtestResultsPictureBox;
        private System.Windows.Forms.Label Pid_lb;
        private System.Windows.Forms.RichTextBox Hemo_TB;
    }
}