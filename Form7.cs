using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalSystemGUI
{
    public partial class Form7 : Form
    {
        Controller controller7= new Controller();

        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1Sample = new Form1();
            form1Sample.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            PaientID_lb.Text = Form1.SetValueForPatientID;
            DataTable dt = controller7.displayBilling(Int32.Parse(Form1.SetValueForPatientID));
            BillGridView.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form0 FormLogOut = new Form0();
            FormLogOut.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PayTB_TextChanged(object sender, EventArgs e)
        {
            //declare the total variable
            int total = 0;
            //loop through the datagrid and sum the column 
            for (int i = 0; i < BillGridView.Rows.Count; i++)
            {
                total += int.Parse(BillGridView.Rows[i].Cells["Medication_price"].Value.ToString());

            }
            for (int i = 0; i < BillGridView.Rows.Count; i++)
            {
                total += int.Parse(BillGridView.Rows[i].Cells["Radiological_price"].Value.ToString());

            }
            for (int i = 0; i < BillGridView.Rows.Count; i++)
            {
                total += int.Parse(BillGridView.Rows[i].Cells["LabTestPrice"].Value.ToString());

            }
            PayTB.Text = total.ToString();
        }

        private void total_lb_Click(object sender, EventArgs e)
        {

        }

        private void InsurnaceTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            PaientID_lb.Text = Form1.SetValueForPatientID;
        }
        private void PaientID_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
