using System;
using System.Web;
using System.Web.UI;
namespace WebApplication
{
    public partial class Editorial : System.Web.UI.MasterPage
    {

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrarusuario.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("administrar_autores.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("administrar_editores.aspx");
        }
    }
}
