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

namespace ADOsqldemo2
{
    public partial class Save : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=PRIME;Initial Catalog=UserManagement;Integrated Security=True");
        public Save()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblUser values('"+txtName.Text+"','"+txtAddress.Text+"');",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Saved..!");


        }
    }
}
