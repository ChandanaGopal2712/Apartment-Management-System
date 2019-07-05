using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms_mini_pro
{
    public partial class Owner_UserControl1 : UserControl
    {
        private static Owner_UserControl1 _instance;
        public static Owner_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Owner_UserControl1();
                }



                return _instance;
            }
        }

        public Owner_UserControl1()
        {
            InitializeComponent();
        }
    }
}
