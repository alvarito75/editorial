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


        // Registrar usuario.
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if (checkMemberExists())
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "showInfo()", true);
            }
            else
            {
                nuevoUsuario();
            }
        }

        
        bool checkMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(_connStr);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from Users where MemberId='" + TextBox8.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void nuevoUsuario()
        {
            try
            {

                SqlConnection con = new SqlConnection(_connStr);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO Users(Nombre, Apellido, Telefono, Ciudad, Edad, FechaNacimiento, Email, Password, Direccion, EstadoCuenta, MemberId) " +
                    "values(@nombre, @apellido, @telefono, @ciudad, @edad, @fechaN, @email, @pass, @direccion, @estado, @memberId)", con);

                cmd.Parameters.AddWithValue("@nombre", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@apellido", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@telefono", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@ciudad", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@edad", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@fechaN", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@direccion", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@estado", "pending");
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
