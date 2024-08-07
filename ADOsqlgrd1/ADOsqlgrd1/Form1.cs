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


namespace ADOsqlgrd1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=PRIME;Initial Catalog=UserManagement;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select *from tblUser", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            grdUserDetais.DataSource= dt;
            grdUserDetais.Show();
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblUser values('" + txtName.Text + "','" + txtAdress.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("User information is successfully saved...!");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from tblUser where UserID='"+txtId.Text+"'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { txtName.Text = dr["UserName"].ToString(); txtAdress.Text = dr["UserAdress"].ToString(); }
            dr.Close();
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAdress.Text = "";
        }
    }
}
