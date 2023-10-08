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

namespace My_Project.Forms
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }
        //SqlConnection con= new SqlConnection(@"Data Source=desktop-p60k9of;Initial Catalog=BookShopDB;User ID=sa;Password=open");
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=BookShopDB;User ID=sa;Password=open");

        private void populate()
        {
            con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();
        }


        private void Billing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookShopDBDataSet.BillTbl' table. You can move, or remove it, as needed.
            this.billTblTableAdapter.Fill(this.bookShopDBDataSet.BillTbl);
            // TODO: This line of code loads data into the 'bookShopDBDataSet.BookTbl' table. You can move, or remove it, as needed.
            this.bookTblTableAdapter.Fill(this.bookShopDBDataSet.BookTbl);
            // TODO: This line of code loads data into the 'bookShopDBDataSet.UserTbl' table. You can move, or remove it, as needed.
            this.userTblTableAdapter.Fill(this.bookShopDBDataSet.UserTbl);

        }

        int n = 0, Grandtotal = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuentity.Text == "" || Convert.ToInt32(txtQuentity.Text) > stock)
            {
                MessageBox.Show("Not Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(txtQuentity.Text) * Convert.ToInt32(txtPrice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtBookTitle.Text;
                newRow.Cells[2].Value = txtQuentity.Text;
                newRow.Cells[3].Value = txtPrice.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                Grandtotal = Grandtotal + total;
                lblTotal.Text = "TK" + Grandtotal;
            }
        }


        int BId = 0, stock = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BookDGV.Rows[e.RowIndex].Cells[0].Value != null)
            {
                BId = int.Parse(BookDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                stock = int.Parse(BookDGV.Rows[e.RowIndex].Cells[4].Value.ToString());

            }

            String CS = "data source=.; database =BookShopDB ; integrated security=true";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select *from BookTbl where BId ='" + BId + "' ", con);
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);

                //rowId = Int64.Parse(dataset.Tables[0].Rows[0][0].ToString());
                txtBookTitle.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
                //txtQuentity.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
                txtPrice.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            }
            con.Close();
        }


        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(txtQuentity.Text);
            try
            {
                con.Open();
                string query = "update BookTbl set BQty=" + newQty + " where BId=" + BId + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Book Updated Successfully");
                con.Close();
                populate();
                //Reset();
                //BId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Reset()
        {
            txtBookTitle.ResetText();
            txtQuentity.ResetText();
            txtPrice.ResetText();
            txtClientName.ResetText();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
