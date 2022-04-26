
namespace HospitalSystemGUI
{
    partial class Form7
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
            this.v = new System.Windows.Forms.Label();
            this.PaientID_lb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InsurnaceTB = new System.Windows.Forms.TextBox();
            this.BillGridView = new System.Windows.Forms.DataGridView();
            this.Medications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medication_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medication_amout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadiologicallabName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Radiological_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTestPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayTB = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.total_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(243, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Finance Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.v.Location = new System.Drawing.Point(12, 135);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(122, 21);
            this.v.TabIndex = 3;
            this.v.Text = "Insurnace status";
            // 
            // PaientID_lb
            // 
            this.PaientID_lb.AutoSize = true;
            this.PaientID_lb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaientID_lb.Location = new System.Drawing.Point(155, 62);
            this.PaientID_lb.Name = "PaientID_lb";
            this.PaientID_lb.Size = new System.Drawing.Size(108, 28);
            this.PaientID_lb.TabIndex = 4;
            this.PaientID_lb.Text = "#Patient ID";
            this.PaientID_lb.Click += new System.EventHandler(this.PaientID_lb_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(630, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Switch";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Log Out ?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InsurnaceTB
            // 
            this.InsurnaceTB.Location = new System.Drawing.Point(164, 133);
            this.InsurnaceTB.Name = "InsurnaceTB";
            this.InsurnaceTB.ReadOnly = true;
            this.InsurnaceTB.Size = new System.Drawing.Size(227, 23);
            this.InsurnaceTB.TabIndex = 13;
            this.InsurnaceTB.TextChanged += new System.EventHandler(this.InsurnaceTB_TextChanged);
            // 
            // BillGridView
            // 
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medications,
            this.Medication_price,
            this.Medication_amout,
            this.RadiologicallabName,
            this.Radiological_price,
            this.LabTestName,
            this.LabTestPrice});
            this.BillGridView.Location = new System.Drawing.Point(12, 182);
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.RowTemplate.Height = 25;
            this.BillGridView.Size = new System.Drawing.Size(743, 150);
            this.BillGridView.TabIndex = 14;
            // 
            // Medications
            // 
            this.Medications.HeaderText = "Medication Name";
            this.Medications.Name = "Medications";
            // 
            // Medication_price
            // 
            this.Medication_price.HeaderText = "Medication_price";
            this.Medication_price.Name = "Medication_price";
            // 
            // Medication_amout
            // 
            this.Medication_amout.HeaderText = "Medication Amount";
            this.Medication_amout.Name = "Medication_amout";
            // 
            // RadiologicallabName
            // 
            this.RadiologicallabName.HeaderText = "Radiological Exam Name";
            this.RadiologicallabName.Name = "RadiologicallabName";
            // 
            // Radiological_price
            // 
            this.Radiological_price.HeaderText = "Radiological ExamPrice";
            this.Radiological_price.Name = "Radiological_price";
            // 
            // LabTestName
            // 
            this.LabTestName.HeaderText = "Lab Test Name";
            this.LabTestName.Name = "LabTestName";
            // 
            // LabTestPrice
            // 
            this.LabTestPrice.HeaderText = "Lab Test Price";
            this.LabTestPrice.Name = "LabTestPrice";
            // 
            // PayTB
            // 
            this.PayTB.Location = new System.Drawing.Point(523, 343);
            this.PayTB.Name = "PayTB";
            this.PayTB.Size = new System.Drawing.Size(185, 23);
            this.PayTB.TabIndex = 17;
            this.PayTB.TextChanged += new System.EventHandler(this.PayTB_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(339, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Pay";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total_lb.Location = new System.Drawing.Point(443, 343);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(48, 21);
            this.total_lb.TabIndex = 18;
            this.total_lb.Text = "Total";
            this.total_lb.Click += new System.EventHandler(this.total_lb_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Database_project.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(767, 468);
            this.Controls.Add(this.total_lb);
            this.Controls.Add(this.PayTB);
            this.Controls.Add(this.BillGridView);
            this.Controls.Add(this.InsurnaceTB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PaientID_lb);
            this.Controls.Add(this.v);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form7";
            this.Text = "Finance Portal";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label PaientID_lb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox InsurnaceTB;
        private System.Windows.Forms.DataGridView BillGridView;
        private System.Windows.Forms.TextBox PayTB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medication_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medication_amout;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadiologicallabName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Radiological_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTestPrice;
        private System.Windows.Forms.Label total_lb;
    }
}