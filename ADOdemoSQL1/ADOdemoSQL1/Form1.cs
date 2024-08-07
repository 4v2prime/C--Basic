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

namespace ADOdemoSQL1
{
    public partial class Form1 : Form
    {
              
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            clsUser objSave = new clsUser(txtName.Text,txtAdress.Text);
            objSave.SaveUser();
            MessageBox.Show("Data Saved Successfully..!");
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
                   
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsUser objgrd = new clsUser();
            DataTable dt = new DataTable();
            dt = objgrd.GridViewShow();
            grdUserData.DataSource = dt;
            grdUserData.Show();
            grdUserData.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e) 
        {
           clsUser objUpdate = new clsUser(Convert.ToInt32( txtid.Text),txtName.Text,txtAdress.Text);
           objUpdate.UpdateUser();
           MessageBox.Show("Data Updated Successfully");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e) 
        {
            clsUser objDelete = new clsUser(Convert.ToInt32(txtid.Text));
            objDelete.DeleteUser();
            MessageBox.Show("Data Deleted Successfully");
        }

        private void btnShow_Click_1(object sender, EventArgs e) {
            clsUser objSave = new clsUser(Convert.ToInt32(txtid.Text));
            SqlDataReader dr;
            dr = objSave.ShowUser();
            while (dr.Read())
            {
                txtName.Text = dr["UserName"].ToString();
                txtAdress.Text = dr["UserAdress"].ToString();
            }
        }
        
    }
}
