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
    public partial class frmDelete : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=PRIME;Initial Catalog=UserManagement;Integrated Security=True");
        public frmDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd= new SqlCommand("delete tblUser\r\nwhere UserID='"+txtDelID.Text+"';",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Deleted...!");
        }
    }
}
