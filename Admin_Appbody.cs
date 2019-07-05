using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace dbms_mini_pro
{
    public partial class Admin_Appbody : Form
    {
        public Admin_Appbody()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
       
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AppBody obj = new AppBody();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Appbody_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!ContentPanel2.Controls.Contains(Admin_Tenant_UserControl1.Instance))
            {
                ContentPanel2.Controls.Add(Admin_Tenant_UserControl1.Instance);
                Admin_Tenant_UserControl1.Instance.Dock = DockStyle.Fill;
                Admin_Tenant_UserControl1.Instance.BringToFront();
            }
            else
            {
                Admin_Tenant_UserControl1.Instance.BringToFront();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ContentPanel2.Controls.Contains(Admin_Vacant_UserControl1.Instance))
            {
                ContentPanel2.Controls.Add(Admin_Vacant_UserControl1.Instance);
                Admin_Vacant_UserControl1.Instance.Dock = DockStyle.Fill;
                Admin_Tenant_UserControl1.Instance.BringToFront();
            }
            else
            {
                Admin_Vacant_UserControl1.Instance.BringToFront();
            }
        }
    }
}
