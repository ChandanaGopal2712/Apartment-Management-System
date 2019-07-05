using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms_mini_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname="chandana", upass="Chandu@2712", name, pwd;
            name = textBox1.Text;
            pwd = textBox2.Text;
            if(name.Equals(uname)&&pwd.Equals(upass))
            {
                //login
               
                MessageBox.Show("LOGIN SUCCESS");
            }
            else
            {
                //dont login
                MessageBox.Show("LOGIN FAILED");

                
            }

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
