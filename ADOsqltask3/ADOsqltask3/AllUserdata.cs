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

namespace ADOsqltask3
{
    public partial class AllUserdata : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=PRIME;Initial Catalog=UserDetails;Integrated Security=True");
        public AllUserdata()
        {
            InitializeComponent();
        }

        private void AllUserdata_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select *from tblUserInfo1 select*from tbluserinfo", conn);
            DataTable dt = new DataTable(); 
            adpt.Fill(dt);
            grdAllUserdata.DataSource = dt;
            grdAllUserdata.Show();
            conn.Close();
        }
    }
}
