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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
