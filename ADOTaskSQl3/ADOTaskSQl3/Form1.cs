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

namespace ADOTaskSQl3
{
    public partial class Form1 : Form

    {
        string g;
        SqlConnection conn = new SqlConnection("Data Source=PRIME;Initial Catalog=UserDetails;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnMale.Checked==true) { g = "Male"; }
        }

        private void rdbtnOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnOther.Checked==true) { g = "Other"; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            string q = "insert into tblUserDetails1 (UserName,UserPhone,UserEmail,UserGender,UserState,UserCity) values('" + txtName.Text + "','" + txtPhone.Text + "','" + txtMail.Text + "','" + g + "','" + cmbbxState.SelectedItem + "','" + cmbbxCity.SelectedItem + "')";
            SqlCommand cmd = new SqlCommand(q,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Details Saved Successfully...!");
        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbxCity.Items.Clear();
            switch (cmbbxState.SelectedItem)
            {
                case "Maharashtra":
                    cmbbxCity.Items.Add("Pune");
                    cmbbxCity.Items.Add("Mumbai");
                    cmbbxCity.Items.Add("Satara");
                    break;
                case "Gujrat":
                    cmbbxCity.Items.Add("Badodara");
                    cmbbxCity.Items.Add("Surat");
                    cmbbxCity.Items.Add("Amdabad");
                    break;
                case "Karnataka":
                    cmbbxCity.Items.Add("Vijapur");
                    cmbbxCity.Items.Add("Gulburg");
                    cmbbxCity.Items.Add("Banglore");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;

            }

        }

        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnFemale.Checked==true) { g = "Female"; }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
