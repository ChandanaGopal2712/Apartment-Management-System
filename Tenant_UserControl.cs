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
    public partial class Tenant_UserControl : UserControl
    {
        private static Tenant_UserControl _instance;
        public static Tenant_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Tenant_UserControl();
                }
             


                return _instance;
            }
        }
        public Tenant_UserControl()
        {
            InitializeComponent();
        }
    }
}
