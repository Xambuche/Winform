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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=TUANANH\SQLEXPRESS; Initial Catalog=LabDB; Integrated Security=True";
            conn.Open();

            //DataTable dt = new DataTable();
            //String sSQL = "SELECT * FROM tblItem WHERE " + "ItemID='" + txtUserID.Text + "' and Size='" + txtPassword.Text + "'";
            //SqlCommand cmd = new SqlCommand(sSQL, conn);
            // SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);

            //DataTable dt1 = new DataTable();
            //String sSQL = "SELECT * FROM Agent WHERE " + "AgentID='" + txtUserID.Text + "' and AgentName='" + txtPassword.Text + "'";
            //SqlCommand cmd1 = new SqlCommand(sSQL, conn);
            //SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            //da1.Fill(dt1);

            String sSQL2 = "SELECT * FROM Orderr WHERE " + "OrderID='" + txtUserID.Text + "' and AgentID='" + txtPassword.Text + "'";
            SqlCommand cmd2 = new SqlCommand(sSQL2, conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            //String sSQL3 = "SELECT * FROM OrderDetail WHERE " + "ID='" + txtUserID.Text + "' and ItemID='" + txtPassword.Text + "'";
            //SqlCommand cmd3 = new SqlCommand(sSQL3, conn);
            //SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            //DataTable dt3 = new DataTable();
            //da3.Fill(dt3);



            if (dt2.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
