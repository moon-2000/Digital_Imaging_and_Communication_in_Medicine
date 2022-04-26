using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystemGUI
{
    public partial class Form3 : Form
    {
        Controller controller3;
        //  private Controller controller = new Controller;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PatientID_lb.Text = Form1.SetValueForPatientID;
        }

        private void Switch_button_Click(object sender, EventArgs e)
        {
            Form1 FormLogOut = new Form1();
            FormLogOut.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                RadioImage_Box.Image = new Bitmap(open.FileName);
            }
        }

        private void ExamName_label_Click(object sender, EventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
           int result3 = controller3.SaveRadiologicalLab(RadioNameListBox.SelectedItem.ToString(), RadiologistReportTB.Text, RadioImage_Box.Image);
            if (result3 == 0 )
            {
                MessageBox.Show("No Data Saved");
            }
            else
            {
                MessageBox.Show("Patient's Data Saved Successfully");
            }
        }

        private void Log_button_Click(object sender, EventArgs e)
        {
            Form0 form1Sample = new Form0();
            form1Sample.Show();
            this.Hide();
           
        }

        private void PatientID_label2_Click(object sender, EventArgs e)
        {
           // PatientID_label2.Text = controller3.getPatientID().ToString();
        }
    }
}
    
