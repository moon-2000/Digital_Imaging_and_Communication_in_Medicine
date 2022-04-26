using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystemGUI
{
    public partial class Form2 : Form
    {
          Controller controller2 = new Controller(); 
        // loadFn is a loading funtion runs after the form runs
        private void loadFn(object sender, EventArgs e)
        {
            controller2 = new Controller();
        }
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load_1(object sender, EventArgs e)
        {
            patientID_label.Text = Form1.SetValueForPatientID;
        }

        public void label7_Click(object sender, EventArgs e)
        {
        //    patientID_label.Text = controller2.getPatientID().ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int result = controller2.SaveMedicalInfo(Int32.Parse(Form1.SetValueForPatientID), Int16.Parse(bloodpress_TB.Text),Int16.Parse(BloodGlucose_TB.Text), Int16.Parse(OxegyenLevel_TB.Text), Int16.Parse(Weight_TB.Text));
            int result2 = controller2.SaveMedicalHistory (MedicalHistory_listBox.SelectedItem.ToString());
             if (result == 0)
            {
                MessageBox.Show("No Data Saved");
            }
            else
            {
                MessageBox.Show("Patient's Medical Data Saved Successfully");
            }
            
        }


      
       
        private void Switch_button_Click(object sender, EventArgs e)
        {
            Form1 form1Sample = new Form1();
            form1Sample.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form0 FormLogOut = new Form0();
            FormLogOut.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
