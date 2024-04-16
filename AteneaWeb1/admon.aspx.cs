using System;

namespace AteneaWeb1
{
    public partial class admon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ConnectionString"] == null || Session["usuario"] == null)
            {
                Response.Redirect("loginAdmon.aspx");
            }
        }


        protected void Proveedores_Click(object sender, EventArgs e)
        {
            Response.Redirect("proveedores.aspx");
        }

        protected void Ingresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("IngresarP.aspx");
        }

        protected void RevisarCot_Click(object sender, EventArgs e)
        {
            Response.Redirect("cotizaciones.aspx");
        }

        protected void cerrarSS_Click(object sender, EventArgs e)
        {
            Session.Remove("ConnectionString");
            Session.Remove("usuario");
            Response.Redirect("loginAdmon.aspx");
        }
    }
}