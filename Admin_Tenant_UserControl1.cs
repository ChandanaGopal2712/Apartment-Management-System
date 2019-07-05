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
    public partial class Admin_Tenant_UserControl1 : UserControl
    {
        private static Admin_Tenant_UserControl1 _instance;
        public static Admin_Tenant_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Admin_Tenant_UserControl1();
                }



                return _instance;
            }
        }
        public Admin_Tenant_UserControl1()
        {
            InitializeComponent();
        }




        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        private void Admin_Tenant_UserControl1_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void refresh_DataGridView()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("ShowTenantInfo", con);
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


                dataGridView1.DataSource = DS.Tables[0];

          

                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
              
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddTenant_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            refresh_DataGridView();

            cmd.Parameters.AddWithValue("@T_id", T_id_textBox.Text);

            cmd.Parameters.AddWithValue("@Fname", FnametextBox.Text);

            cmd.Parameters.AddWithValue("@Lname", LnametextBox.Text);

            cmd.Parameters.AddWithValue("@Phone", PhonetextBox.Text);

            cmd.Parameters.AddWithValue("@Email_id", EmailtextBox.Text);

            cmd.Parameters.AddWithValue("@No_of_persons", No_Of_personstextBox.Text);

            cmd.Parameters.AddWithValue("@Block_no", Block_notextBox.Text);

            cmd.Parameters.AddWithValue("@Flat_no", Flat_notextBox.Text);

            cmd.Parameters.AddWithValue("@Floor_no", Floor_notextBox.Text);

            cmd.Parameters.AddWithValue("@No_of_vehicles", No_Of_vehiclestextBox.Text);
           


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
        

       

        private void T_id_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

        }

        private void FnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("TenantSearch_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@T_id", SearchTenant_textBox.Text);

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


                dataGridView1.DataSource = DS.Tables[0];



                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void DeleteTupleButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("TenantDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@T_id", T_id_textBox.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<<INVALID SQL OPERATION:" + ex);
                }
                con.Close();
                refresh_DataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void SearchTenant_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            T_id_textBox.Text = "";
            FnametextBox.Text = "";
            LnametextBox.Text = "";
            PhonetextBox.Text = "";
            EmailtextBox.Text = "";
            No_Of_personstextBox.Text = "";
            Block_notextBox.Text = "";
            Flat_notextBox.Text = "";
            Floor_notextBox.Text = "";
            No_Of_vehiclestextBox.Text = "";
            


        }
    }
}
