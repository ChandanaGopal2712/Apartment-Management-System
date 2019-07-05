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
    public partial class AppBody : Form
    {

        public const int WM_NCLBUTTON = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int IParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AppBody()
        {
            InitializeComponent();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            log_in_timer.Start();
        }

        private void log_in_timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<=1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                log_in_timer.Stop();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void TitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle,WM_NCLBUTTON, HT_CAPTION, 0);
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Appbody obj = new Admin_Appbody();
            this.Hide();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Tenant_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Tenant_UserControl.Instance);
                Tenant_UserControl.Instance.Dock = DockStyle.Fill;
                Tenant_UserControl.Instance.BringToFront();
            }
            else
            {
               Tenant_UserControl.Instance.BringToFront();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Tenant_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Owner_UserControl1.Instance);
                Owner_UserControl1.Instance.Dock = DockStyle.Fill;
                Owner_UserControl1.Instance.BringToFront();
            }
            else
            {
                Owner_UserControl1.Instance.BringToFront();

            }
        }
    }
}
