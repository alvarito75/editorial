using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication
{
    public partial class Editorial : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true; // login link button
                    LinkButton2.Visible = true; // registrarse link button

                    LinkButton3.Visible = false; // salir link button
                    LinkButton7.Visible = false; // hello user link button


                    LinkButton6.Visible = true; // login admin link button
                    LinkButton11.Visible = false; // administrar autores link button
                    LinkButton12.Visible = false; // administrar editores link button
                    LinkButton8.Visible = false; // Inventario link button
                    LinkButton9.Visible = false; // venta de libros link button
                    LinkButton10.Visible = false; // member management link button

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; // login link button
                    LinkButton2.Visible = false; // registrarse link button

                    LinkButton3.Visible = true; // salir link button
                    LinkButton7.Visible = true; // hello user link button
                    LinkButton7.Text = "Hello " + Session["username"].ToString();


                    LinkButton6.Visible = true; // login admin link button
                    LinkButton11.Visible = false; // administrar autores link button
                    LinkButton12.Visible = false; // administrar editores link button
                    LinkButton8.Visible = false; // Inventario link button
                    LinkButton9.Visible = false; // venta de libros link button
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; // login link button
                    LinkButton2.Visible = false; // registrarse link button

                    LinkButton3.Visible = true; // salir link button
                    LinkButton7.Visible = true; // hello user link button
                    LinkButton7.Text = "Hello Admin";


                    LinkButton6.Visible = false; // login admin link button
                    LinkButton11.Visible = true; // administrar autores link button
                    LinkButton12.Visible = true; // administrar editores link button
                    LinkButton8.Visible = true; // Inventario link button
                    LinkButton9.Visible = true; // venta de libros link button
                    LinkButton10.Visible = true; // administrar usuarios link button
                }
            }
            catch (Exception ex)
            {


            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrarusuario.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("inventario.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("vender_libro.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("administrar_miembros.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("administrar_autores.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("administrar_editores.aspx");
        }

        //logout button
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true; // login link button
            LinkButton2.Visible = true; // registrarse link button

            LinkButton3.Visible = false; // salir link button
            LinkButton7.Visible = false; // hello user link button


            LinkButton6.Visible = true; // login admin link button
            LinkButton11.Visible = false; // administrar autores link button
            LinkButton12.Visible = false; // administrar editores link button
            LinkButton8.Visible = false; // Inventario link button
            LinkButton9.Visible = false; // venta de libros link button
            LinkButton10.Visible = false; // administrar usuarios link button
        }


    }
}
