using System;
using System.Web;
using System.Web.UI;

using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI.WebControls;

namespace WebApplication
{

    public partial class test : System.Web.UI.Page
    {
        private static string _connStr = @"
            Server=127.0.0.1,1433;
            Database=EditorialDB;
            User Id=SA;
            Password=Alvarito_*5
        ";


        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('testing');</script>");

            try
            {
                Response.Write("<script>console.log('Sign Up Successful. Go to User Login to Login');</script>");
                string hola = tbadmin.Text;
                Response.Write("<script>console.log('" + tbadmin.Text + "');</script>");
                SqlConnection con = new SqlConnection(_connStr);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO Tests(Id, Nombre, Direccion) values(@id, @name, @direccion)", con);
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.Parameters.AddWithValue("@name", hola);
                cmd.Parameters.AddWithValue("@direccion", hola);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>console.log('Sign Up Successful. Go to User Login to Login');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }


        }

    }
}

