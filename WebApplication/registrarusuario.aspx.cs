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

    public partial class registrarusuario : System.Web.UI.Page
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

                SqlConnection con = new SqlConnection(_connStr);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO Users(Nombre, Apellido, Telefono, Ciudad, Edad, FechaNacimiento, Email, Password, Direccion, MemberId) " +
                    "values(@nombre, @apellido, @telefono, @ciudad, @edad, @fechaN, @email, @pass, @direccion, @memberId)", con);

                cmd.Parameters.AddWithValue("@nombre", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@apellido", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@telefono", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@ciudad", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@edad", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@fechaN", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@direccion", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@memberId", TextBox8.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();

                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "showSuccessful()", true);

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}
