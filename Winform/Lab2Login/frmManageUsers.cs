using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Login
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=TUANANH\SQLEXPRESS; Initial Catalog=LabDB;Integrated Security=True";
            conn.Open();

            ////Item
            //String sSQL = "SELECT * FROM tblItem ";
            //SqlCommand cmd = new SqlCommand(sSQL, conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            ////Agent
            // String sSQL1 = "SELECT * FROM Agent ";
            //SqlCommand cmd1 = new SqlCommand(sSQL1, conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd1);
            //DataTable dt1 = new DataTable();
            //da1.Fill(dt1);

            ///Order
            //String sSQL2 = "SELECT * FROM Order ";
            //SqlCommand cmd2 = new SqlCommand(sSQL2, conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd2);
            //DataTable dt2 = new DataTable();
            //da.Fill(dt2);

            //OrderDetail
            String sSQL3 = "SELECT * FROM OrderDetail ";
            SqlCommand cmd3 = new SqlCommand(sSQL3, conn);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);



            ///Order
            if (dt3.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt3;
            }
            else
            {
                MessageBox.Show("No Data!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
                return;
            try
            {
                {
                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(local); Initial Catalog=LabDB;Integrated Security=True";
            conn.Open();
            //Item
            //String sSQL = "INSERT INTO tblItem (ItemID, ItemName, Size )VALUES(@IID, @Name, @Size)";
            //SqlCommand cmd = new SqlCommand(sSQL, conn);

            //Agent
            //String sSQL1 = "INSERT INTO Agent (AgentID, AgentName, Address)VALUES(@AID, @AName, @Address)";
            //SqlCommand cmd1 = new SqlCommand(sSQL1, conn);

            //Order 
            //String sSQL2 = "INSERT INTO Order (OrderID, OrderDate, AgentID)VALUES(@OID, @ODate, @AID)";
            //SqlCommand cmd2 = new SqlCommand(sSQL2, conn);

            //OrderDetail
            String sSQL3 = "INSERT INTO OrderDetail (ID, OrderID, ItemID, Quantity, UnitAmount)VALUES(@ID, @OID, @IID, @Quan, @UAmount)";
            SqlCommand cmd3 = new SqlCommand(sSQL3, conn);

            try
            {
                {
                    //cmd.ExecuteNonQuery();
                    //cmd1.ExecuteNonQuery();
                    //cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                {
                    throw new Exception("Error:" + ex.Message);
                }
                MessageBox.Show("Save successfully!");
                dataGridView1.Refresh();
            }
        }
    }
}

