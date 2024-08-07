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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ADOsqltask3
{
    public partial class frmLogin : Form
    {
        
        SqlConnection conn =new SqlConnection("Data Source=PRIME;Initial Catalog=UserDetails;Integrated Security=True");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mail=txtEmail.Text;
            string pass = txtPassword.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblUserInfo1 where UserEmail='" + mail + "'  and UserPassword='" + pass + "'", conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt= new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            adpt.Fill(dt);
            //conn.Close();
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Login Successful");
                AllUserdata objgrd=new AllUserdata();
                objgrd.Show();
            }
            else
            {
                MessageBox.Show("Login UnSuccessful");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text= string.Empty;
            txtPassword.Text= string.Empty;
        }
    }
}
