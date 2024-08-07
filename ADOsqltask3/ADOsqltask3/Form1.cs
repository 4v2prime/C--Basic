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
    public partial class Form1 : Form
    {
        string gen;
        SqlConnection conn = new SqlConnection("Data Source=PRIME;Initial Catalog=UserDetails;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;  

        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbxCity.Items.Clear();
            if (cmbbxState.Text == "Maharashtra") {
                cmbbxCity.Items.Add("Pune");
                cmbbxCity.Items.Add("Mumbai");
                cmbbxCity.Items.Add("Satara");
            }
            else if (cmbbxState.Text == "Karnataka")
            {
                cmbbxCity.Items.Add("Banglore");
                cmbbxCity.Items.Add("Vijapur");
                cmbbxCity.Items.Add("Gulburga");
            }
            else if(cmbbxState.Text == "Gujrat")
            {
                cmbbxCity.Items.Add("Surat");
                cmbbxCity.Items.Add("Vadodara");
                cmbbxCity.Items.Add("Amhdabad");
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //conn.Open();
            //SqlDataAdapter adpt=new SqlDataAdapter("select *from tblUserInfo1", conn);
            //DataTable dt = new DataTable();
            //adpt.Fill(dt);
            //grdUserDetails.DataSource = dt;
            //grdUserDetails.Show();
            //conn.Close();

        }

        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnMale.Checked==true) { gen = "Male"; }
        }

        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnFemale.Checked == true) { gen = "Female"; }
        }

        private void rdbtnOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOther.Checked == true) { gen = "Other"; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblUserInfo1 values ('" + txtName.Text+"','"+txtPhone.Text+"','"+txtEmail.Text+"','"+gen+"','"+cmbbxState.SelectedItem+"','"+cmbbxCity.SelectedItem+"','"+txtPassword.Text+"')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Saved Successfully...!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update tblUserInfo1 set UserName='" + txtName.Text+"',UserPhone='"+txtPhone.Text+"',UserEmail='"+txtEmail.Text+"',UserGender='"+gen+"',UserState='"+cmbbxState.SelectedItem+"',UserCity='"+cmbbxCity.SelectedItem+"',UserPassword='"+txtPassword.Text+"' where UserID='"+txtID.Text+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Updated Successfully...!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete tblUserInfo1 where userID='" + txtID.Text+"'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data is Successfully Deleted...");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxState.Text = string.Empty;
            cmbbxCity.Text = string.Empty;
            txtName.Text = " ";
            txtPhone.Text = " ";
            txtEmail.Text = " ";
            txtID.Text = " ";
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
            rdbtnOther.Checked = false;
            txtPassword.Text= " ";
            AllUserdata obj = new AllUserdata();
            obj.Show();
            

        }

        private void lblRahitech_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdUserDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from tblUserInfo1 where UserID='"+txtID.Text+"'", conn);
            SqlDataReader dr;
            dr=cmd.ExecuteReader();
            while (dr.Read()) {
                txtName.Text = dr["UserName"].ToString();
                txtPhone.Text = dr["UserPhone"].ToString();
                txtEmail.Text = dr["UserEmail"].ToString();
                gen = dr["UserGender"].ToString();

                switch (gen)
                {
                    case "Male  ":
                        rdbtnMale.Checked = true;
                        break;
                    case "Female":
                        rdbtnFemale.Checked = true;
                        break;
                    case "Other ":
                        rdbtnOther.Checked = true;
                        break;
                    default:
                        break;
                }
                cmbbxState.SelectedItem= dr["UserState"];
                cmbbxCity.SelectedItem = dr["UserCity"];
                

            }
            dr.Close();
            conn.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin objLogin= new frmLogin();
            //objLogin.MdiParent = this;
            objLogin.Show();
        }
    }
}
