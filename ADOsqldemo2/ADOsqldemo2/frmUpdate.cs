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

namespace ADOsqldemo2
{
    public partial class frmUpdate : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=PRIME;Initial Catalog=UserManagement;Integrated Security=True");
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd=new SqlCommand("update tblUser set UserName='"+ txtName.Text + "',UserAdress='"+ txtAddress.Text + "' where UserID='"+txtupID.Text+"';",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Updated..!");
        }
    }
}
