
namespace HospitalSystemGUI
{
    partial class Form6
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
            this.PatientID_lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MedicitionsNameLB = new System.Windows.Forms.ListBox();
            this.Switch_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Precribed_Medication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(260, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PatientID_lb
            // 
            this.PatientID_lb.AutoSize = true;
            this.PatientID_lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientID_lb.Location = new System.Drawing.Point(167, 94);
            this.PatientID_lb.Name = "PatientID_lb";
            this.PatientID_lb.Size = new System.Drawing.Size(87, 27);
            this.PatientID_lb.TabIndex = 2;
            this.PatientID_lb.Text = "#Patient ID";
            this.PatientID_lb.UseCompatibleTextRendering = true;
            this.PatientID_lb.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prescribed Medications";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dispensed Medications";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MedicitionsNameLB
            // 
            this.MedicitionsNameLB.AllowDrop = true;
            this.MedicitionsNameLB.FormattingEnabled = true;
            this.MedicitionsNameLB.ItemHeight = 15;
            this.MedicitionsNameLB.Items.AddRange(new object[] {
            "Ketafan",
            "Panadol",
            "Biofreze",
            "Chromax",
            "Cataflam",
            "Catafast",
            "Cetal",
            "Congestal",
            "Cold and flu",
            "Flagyl",
            "Brufen",
            "Digestin"});
            this.MedicitionsNameLB.Location = new System.Drawing.Point(29, 177);
            this.MedicitionsNameLB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MedicitionsNameLB.Name = "MedicitionsNameLB";
            this.MedicitionsNameLB.Size = new System.Drawing.Size(243, 49);
            this.MedicitionsNameLB.TabIndex = 5;
            this.MedicitionsNameLB.SelectedIndexChanged += new System.EventHandler(this.MedicitionsNameLB_SelectedIndexChanged);
            // 
            // Switch_button
            // 
            this.Switch_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Switch_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Switch_button.ForeColor = System.Drawing.Color.Black;
            this.Switch_button.Location = new System.Drawing.Point(671, 555);
            this.Switch_button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Switch_button.Name = "Switch_button";
            this.Switch_button.Size = new System.Drawing.Size(95, 42);
            this.Switch_button.TabIndex = 7;
            this.Switch_button.Text = "Switch";
            this.Switch_button.UseVisualStyleBackColor = false;
            this.Switch_button.Click += new System.EventHandler(this.Switch_button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(14, 555);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(272, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Medication Dispensed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Precribed_Medication,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(29, 280);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(243, 153);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(435, 177);
            this.AmountTB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(230, 23);
            this.AmountTB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(435, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(435, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Prescribed Medication";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(776, 539);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 23);
            this.textBox1.TabIndex = 16;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(435, 280);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(341, 153);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // Precribed_Medication
            // 
            this.Precribed_Medication.HeaderText = "Precribed_Medication";
            this.Precribed_Medication.Name = "Precribed_Medication";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Database_project.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(805, 611);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Switch_button);
            this.Controls.Add(this.MedicitionsNameLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatientID_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PatientID_lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox MedicitionsNameLB;
        private System.Windows.Forms.Button Switch_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precribed_Medication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}