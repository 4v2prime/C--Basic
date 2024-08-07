using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADOdemoSQL1
{
  
    public class clsUser
    {
        SqlConnection con = new SqlConnection("Data Source=PRIME;Initial Catalog=UserManagement;Integrated Security=True");

        public string UserName {  get; set; }
        public string UserAddress { get; set; }
        public int UserId { get; set; }
        public clsUser() { }

        public clsUser(string name,string address) 
        {
            UserName = name;
            UserAddress = address;
        }
        public clsUser(int id,string name,string adress) 
        {
            UserId = id;
            UserName = name;
            UserAddress = adress;
        }
        public clsUser(int id) 
        {
            UserId = id;
        }
    public void SaveUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveUser");
            cmd.Parameters.AddWithValue("@UName",UserName);
            cmd.Parameters.AddWithValue("@UAddress",UserAddress);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    public void UpdateUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserManagement", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateUser");
            cmd.Parameters.AddWithValue("@Id",UserId);
            cmd.Parameters.AddWithValue("@UName",UserName);
            cmd.Parameters.AddWithValue("@UAddress",UserAddress);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    public void DeleteUser() 
        
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserManagement",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteUser");
            cmd.Parameters.AddWithValue("@Id",UserId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    public SqlDataReader ShowUser() 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserManagement",con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowUserData");
            cmd.Parameters.AddWithValue("@Id", UserId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            
  
        }
    public DataTable GridViewShow()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UserManagement", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GridViewData");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
           
        }
    


    }
}
