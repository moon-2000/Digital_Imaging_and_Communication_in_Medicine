using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystemGUI
{
    public partial class Form1 : Form
    {
        Controller controller1 = new Controller();
        public static string SetValueForPatientID;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        

        private void EnterpatientID_label_Click(object sender, EventArgs e)
        {

        }

        private void Proceed_button_Click(object sender, EventArgs e)
        {
            if (controller1.patientExist(Int32.Parse(PatientId_TB.Text)) == 0)
            {
                MessageBox.Show("Patient ID is incorrect or not exist");
            }
            else
            {
                SetValueForPatientID = PatientId_TB.Text;
                 string msg = controller1.UserPosition(Form0.SetValueForUsername);
                  MessageBox.Show(msg);
                if (controller1.UserPosition(Form0.SetValueForUsername) == "Hemologist          ")
                { 
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }
                else if (controller1.UserPosition(Form0.SetValueForUsername) == "Nurse               ")
                {
                Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else if (controller1.UserPosition(Form0.SetValueForUsername) == "Accountant          ")
                {
                    Form7 form7 = new Form7();
                    form7.Show();
                    this.Hide();
                }
                else if (controller1.UserPosition(Form0.SetValueForUsername) == "Pharmacist        ")
                {
                    Form6 form6 = new Form6();
                    form6.Show();
                    this.Hide();
                }
                else if (controller1.UserPosition(Form0.SetValueForUsername) == "Reciptionitst       ")
                {
                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Hide();
                }
                
                else if (controller1.UserPosition(Form0.SetValueForUsername) == "Radiologist         ")
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Can't determine the user position");
                }
            } 
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            UserWelcome_lb.Text = Form0.SetValueForUsername;
        }

        private void welcome_label_Click(object sender, EventArgs e)
        {

        }
    }
}