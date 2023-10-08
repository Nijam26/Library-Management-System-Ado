using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project
{
    public partial class Users : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=BookShopDB;User ID=sa;Password=open");

        public Users()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO UserTbl (UName,UPhone,UAdd,UPass) VALUES (@UName, @UPhone, @UAdd, @UPass)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@UPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@UAdd", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@UPass", txtPassword.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Succesfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtUserName.ResetText();
            txtPhone.ResetText();
            txtAddress.ResetText();
            txtPassword.ResetText();

            txtUserName.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
              Login obj = new Login();
              obj.Show();
              this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UId == 0)
            {
                MessageBox.Show("Select a User to delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from UserTbl where UId=" + UId + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int UId = 0;
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (UserDGV.Rows[e.RowIndex].Cells[0].Value != null)
            {
                UId = int.Parse(UserDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            String CS = "data source=.; database =BookShopDB ; integrated security=true";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select *from BookTbl where BId ='" + UId + "' ", con);
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);

                //rowId = Int64.Parse(dataset.Tables[0].Rows[0][0].ToString());
                txtUserName.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
                txtPhone.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
                txtAddress.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
                txtPassword.Text = UserDGV.SelectedRows[0].Cells[4].Value.ToString();

                if (txtUserName.Text == "")
                {
                    UId = 0;
                }
                else
                {
                    UId = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
                
            }
            con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (UId == 0)
            {
                MessageBox.Show("Select a User to edit");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update UserTbl set UName='" + txtUserName.Text + "',UPhone='" + txtPhone.Text + "',UAdd='" + txtAddress.Text + "',UPass=" + txtPassword.Text + " where BId=" + UId + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
                    con.Close();
                    populate();
                    Reset();
                    UId = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }
    }
}
