using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using CrystalDecisions.Shared;
using My_Project.Forms;

namespace My_Project
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
        }
        //SqlConnection con= new SqlConnection(@"Data Source=desktop-p60k9of;Initial Catalog=BookShopDB;User ID=sa;Password=open");
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=BookShopDB;User ID=sa;Password=open");

        private void populate()
        {
            con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Fillter()
        {
            con.Open();
            string query = "select * from BookTbl where BCat='"+cboBoxSearch.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookTitle.Text == "" || txtAuthar.Text == "" || txtQuentity.Text == "" || txtPrice.Text == "" || cboBoxCategories.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    //string query = "insert into BookTbl('" + txtBookTitle.Text + "','" + txtAuthar.Text + "','" + cboBoxCategories.SelectedItem.ToString() + "'," + txtQuentity.Text + "," + txtPrice.Text + ")";
                    //SqlCommand cmd = new SqlCommand(query, con);

                    string query = "INSERT INTO BookTbl (BTitle, BAuthor, BCat, BQty, BPrice) VALUES (@BTitle, @BAuthor, @BCat, @BQty, @BPrice)";
                    SqlCommand cmd = new SqlCommand(query, con, transaction);
                    cmd.Parameters.AddWithValue("@BTitle", txtBookTitle.Text);
                    cmd.Parameters.AddWithValue("@BAuthor", txtAuthar.Text);
                    cmd.Parameters.AddWithValue("@BCat", cboBoxCategories.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@BQty", Convert.ToInt32(txtQuentity.Text));
                    cmd.Parameters.AddWithValue("@BPrice", Convert.ToInt32(txtPrice.Text));

                    cmd.ExecuteNonQuery();

                    // perform other database operations within the transaction if needed

                    transaction.Commit();
                    MessageBox.Show("Book Saved Succesfully");
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


   

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookShopDBDataSet.BookTbl' table. You can move, or remove it, as needed.
            this.bookTblTableAdapter.Fill(this.bookShopDBDataSet.BookTbl);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtBookTitle.ResetText();
            txtAuthar.ResetText();
            cboBoxCategories.SelectedIndex = -1;
            txtQuentity.ResetText();
            txtPrice.ResetText();

            txtBookTitle.Focus();
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

        private void cboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fillter();
        }

        private void butRef_Click(object sender, EventArgs e)
        {
            populate();
        }


        int BId = 0;
        Int64 rowId;
         private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                    if (BookDGV.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        BId = int.Parse(BookDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }

                    String CS = "data source=.; database =BookShopDB ; integrated security=true";
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("select *from BookTbl where BId ='" + BId + "' ", con);
                        con.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataset = new DataSet();
                        dataAdapter.Fill(dataset);

                        rowId = Int64.Parse(dataset.Tables[0].Rows[0][0].ToString());
                        txtBookTitle.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
                        txtAuthar.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
                        cboBoxCategories.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
                        txtQuentity.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
                        txtPrice.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
                    }
                       con.Close();



            /*                 if (BookDGV.SelectedRows.Count > 0)
                                {
                                    btnDelete.Enabled = true;
                                    btnEdit.Enabled = true;
                                }
                                else
                                {
                                    btnDelete.Enabled = false;
                                    btnEdit.Enabled = false;
                                }

                                txtBookTitle.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
                                txtAuthar.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
                                cboBoxCategories.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
                                txtQuentity.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
                                txtPrice.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
                                if (txtBookTitle.Text == "")
                                {
                                    BId = 0;
                                }
                                else
                                {
                                    BId = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
                                }*/
        }



        private void btnDelete_Click(object sender, EventArgs e)
                {
                    if (BId == 0)
                    {
                        MessageBox.Show("Select a book to delete");
                    }
                    else
                    {
                        try
                        {
                            con.Open();
                            string query = "delete from BookTbl where BId=" + BId + "";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Book Deleted Successfully");
                            con.Close();
                            populate();
                            Reset();
                            BId = 0;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }

                private void btnEdit_Click(object sender, EventArgs e)
                {
                    if (BId == 0)
                    {
                        MessageBox.Show("Select a book to edit");
                    }
                    else
                    {
                        try
                        {
                            con.Open();
                            string query = "update BookTbl set BTitle='" + txtBookTitle.Text + "',BAuthor='" + txtAuthar.Text + "',BCat='" + cboBoxCategories.SelectedItem.ToString() + "',BQty=" + txtQuentity.Text + ",BPrice=" + txtPrice.Text + " where BId=" + BId + "";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Book Updated Successfully");
                            con.Close();
                            populate();
                            Reset();
                            BId = 0;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from BookTbl", con);
            SqlDataAdapter adapter= new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "BookTbl");
            Report sture = new Report();
            sture.SetDataSource(ds);
            reportForm.crystalReportViewer1.ReportSource = sture;
            reportForm.crystalReportViewer1.Refresh();
            con.Close();
        }
    }
}
