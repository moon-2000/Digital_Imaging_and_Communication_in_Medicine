using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystemGUI
{
    public partial class Form6 : Form
    { Controller controller6= new Controller();
         public Form6()
        {
            InitializeComponent();
           // PatientIDLabel.Text = controller6.getPatientID().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmountTB.Text = MedicitionsNameLB.SelectedItem.ToString();
            
            this.dataGridView1.Rows.Add(AmountTB.Text, AmountTB.Text);
            int result4 = controller6.SaveMedications(AmountTB.Text, Int32.Parse(AmountTB.Text));
            if (result4 == 0)
            {
                MessageBox.Show("No Medication Added");
            }
            else
            {
                MessageBox.Show("Medication Addd Successfully");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Switch_button_Click(object sender, EventArgs e)
        {
            Form1 form1Sample = new Form1();
            form1Sample.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form0 FormLogOut = new Form0();
            FormLogOut.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
         //   PatientIDLabel.Text = controller6.getPatientID().ToString();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            PatientID_lb.Text = Form1.SetValueForPatientID;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            PatientID_lb.Text = Form1.SetValueForPatientID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MedicitionsNameLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (DataRowView rowView in MedicitionsNameLB.SelectedItems)
            {
                int index = dataGridView1.Rows.Add();
                var Prescribed_Medications = rowView["Prescribed_Medication"].ToString();
                var amount = rowView["Amount"].ToString();
                dataGridView1.Rows[index].Cells["Column1"].Value = Prescribed_Medications;
                dataGridView1.Rows[index].Cells["Column2"].Value = amount;
            }
        }
    }
    }

