using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace dbms_mini_pro
{
    public partial class Admin_Vacant_UserControl1 : UserControl
    {
        private static Admin_Vacant_UserControl1 _instance;
        public static Admin_Vacant_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Admin_Vacant_UserControl1();
                }



                return _instance;
            }
        }
        public Admin_Vacant_UserControl1()
        {
            InitializeComponent();
        }




        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
       

        public void refresh_DataGridView()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("ShowVacantFlat_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("     INVALID SQL OPERATION:\n" + ex);
                }
                con.Close();


              dataGridView1. DataSource = DS.Tables[0];



               

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Admin_Vacant_UserControl1_Load_1(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Tuple_Button_Click(object sender, EventArgs e)
        {

        }

        private void Add_Tuple_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddVacantFlat_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            refresh_DataGridView();

            cmd.Parameters.AddWithValue("@Flat_no", Flat_no_textBox.Text);

            cmd.Parameters.AddWithValue("@Block_no", Block_no_textBox.Text);

            cmd.Parameters.AddWithValue("@Floor_no", Floor_no_textBox.Text);

            cmd.Parameters.AddWithValue("@No_of_BHK", No_of_BHK_textBox.Text);

            cmd.Parameters.AddWithValue("@Rent", Rent_textBox.Text);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("       <<< INVALID SQL OPERATION:\n" + ex);
            }

            con.Close();
            refresh_DataGridView();
        }
    }
}
