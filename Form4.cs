using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystemGUI
{
    public partial class Form4 : Form
    {
        Controller controller4;
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form0 FormLogOut = new Form0();
            FormLogOut.Show();
            this.Hide();
        }

        private void Switch_button_Click(object sender, EventArgs e)
        {
            Form1 form1Sample = new Form1();
            form1Sample.Show();
            this.Hide();
        }

        private void PatientID_label2_Click(object sender, EventArgs e)
        {
          //  PatientID_label2.Text = controller4.getPatientID().ToString();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
           int result4 = controller4.SaveLab(ExaminationName_listBox1.SelectedItem.ToString(), Hemo_TB.Text, LabtestResultsPictureBox.Image);
            if (result4 == 0)
            {
                MessageBox.Show("No Data Saved");
            }
            else
            {
                MessageBox.Show("Lab test's Data Saved Successfully");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Pid_lb.Text = Form1.SetValueForPatientID;
        }
    }
}
