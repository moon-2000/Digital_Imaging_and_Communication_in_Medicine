using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystemGUI
{
    public partial class Form5 : Form
    {
        Controller controller5; 
        public Form5()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterGenerateHospitalID_button_Click(object sender, EventArgs e)
        {
            int result = controller5.savePatientData(PatientFirstNameTB.Text, PatientLastNameTB.Text, Int32.Parse(PatientNationalIDTB.Text), Int32.Parse(PatientAgeTB.Text), PatientAddressTB.Text, PatientGenderTB.Text, Int32.Parse(PatientHeightTB.Text), InsurnaceStaueLB.SelectedItem.ToString(), Int32.Parse(PatientPhoneTB.Text), Int32.Parse(EmergencyPhoneTB.Text));
            
            if (result == 0 )
            {
                MessageBox.Show("No Data Saved");
            }
            else
            {
                MessageBox.Show("Patient's Data Saved Successfully");
            }


        }




        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Form0 form1Sample = new Form0();
            form1Sample.Show();
            this.Hide();
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            Form1 FormLogOut = new Form1();
            FormLogOut.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
