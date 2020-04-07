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
    public partial class perfilusuario : System.Web.UI.Page
    {
        private static string _connStr = @"
            Server=127.0.0.1,1433;
            Database=EditorialDB;
            User Id=SA;
            Password=Alvarito_*5
        ";

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

              

                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "showSuccessful()", true);

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}
