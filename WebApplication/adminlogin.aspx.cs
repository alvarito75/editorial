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

    public partial class adminlogin : System.Web.UI.Page
    {
        private static string _connStr = @"
            Server=127.0.0.1,1433;
            Database=EditorialDB;
            User Id=SA;
            Password=Alvarito_*5
        ";

        // user login
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connStr);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("select * from Admin where Username='" + TextBox1.Text.Trim() + "' AND Password='" + TextBox2.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //Response.Write("<script>alert('" + dr.GetValue(2).ToString() + "');</script>");
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "showSuccessful()", true);
                        Session["username"] = dr.GetValue(0).ToString();
                        Session["fullname"] = dr.GetValue(2).ToString();
                        Session["role"] = "admin";
                        //Session["status"] = dr.GetValue(10).ToString();

                    }
                    Response.Redirect("/");
                }
                else
                {
                    //Response.Write("<script>alert('Invalid credentials');</script>");
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "showError()", true);
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
