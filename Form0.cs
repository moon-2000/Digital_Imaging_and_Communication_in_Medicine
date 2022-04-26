using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystemGUI
{
    public partial class Form0 : Form
    {
        Controller controller0 =  new Controller() ;
        public static string SetValueForUsername = "";
        public static string SetValueForUserpass = "";
       
        public Form0()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            //send a recovery code to the user
           //controller0.sendRecoveryCode(Username_TB.Text);
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {    
           
            
          
           if(controller0.ExistUsername(Username_TB.Text, Int32.Parse(Password_TB.Text)) == 0){
                MessageBox.Show("Username or Passward is incorrect");

            }
            else
            {
                SetValueForUsername = Username_TB.Text;
                SetValueForUserpass = Password_TB.Text;
                //string user = Username_TB.Text;
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void RememberMeCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Password_TB_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
